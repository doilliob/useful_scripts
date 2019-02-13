using GIAToASURSOConverter.algorythm;
using GIAToASURSOConverter.domain;
using GIAToASURSOConverter.log;
using GIAToASURSOConverter.manager;
using GIAToASURSOConverter.office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GIAToASURSOConverter
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //Загружаем заявления студентов (FISGIA)
            FISGIAObjectManager manager = new FISGIAObjectManager();
            manager.LoadFiles();

            Logger.getInstance().log("Загружено студентов " + manager.getCount().ToString());
            /*List <ASURSOObject> list = manager.getAllArrived();
            Logger.getInstance().log("Отобрано студентов " + list.Count.ToString());
            (new LogForm(Logger.getInstance().getAllLogs())).ShowDialog();*/

            // Смотрим найденных студентов
            /*ExcelDocumentManager office = new ExcelDocumentManager();
            office.setVisible(true);
            office.CreateExcelApplication();
            office.CreateWorkbook();
            office.OpenSheet();

            office.toFirstRow();
            office.cell(1).Value = "Найдены данные";
            office.toNextRow();
            int i = 1;
            foreach(String name in (new ASURSOObject()).Descriptions())
            {
                office.cell(i).Value = name;
                i++;
            }
            office.toNextRow();

            foreach(ASURSOObject obj in list)
            {
                for(int j=1; j<= obj.Fields().Length; j++)
                {
                    office.cell(j).Value = (obj.Field(j).Contains("Group") ? "'" : "")  + obj.Get(j);
                }
                office.toNextRow();
            }*/


            // Смотрим, есть ли студенты, прошедшие по приказу (knowlege) но не найденные в заявлениях (FISGIA)
            ExcelDocumentManager office = new ExcelDocumentManager();
            office.setVisible(true);
            office.CreateExcelApplication();
            office.CreateWorkbook();
            office.OpenSheet();

            office.toFirstRow();
            office.cell(1).Value = "Не найдены данные";
            office.toNextRow();
            office.cell(1).Value = "Фамилия";
            office.cell(2).Value = "Имя";
            office.cell(3).Value = "Отчество";
            office.cell(4).Value = "Группа";
            office.toNextRow();

            
            List<ArrivedStudentObject> allArrived = new GIAToASURSOConverter.knowlege.ArrivedStudentsKnowlege().getAll();
            
            foreach (ArrivedStudentObject obj in allArrived)
            {
                bool found = false;

                //=====================================================================================
                // Поиск в найденных 
                //foreach (ASURSOObject aobj in list)
                foreach (FISGIAObject aobj in manager.getAll())
                {
                    String family = obj.Get("Family");
                    String name = obj.Get("Name");
                    String sername = obj.Get("Sername");

                    String family2 = aobj.Get("Family");
                    String name2 = aobj.Get("Name");
                    String sername2 = aobj.Get("Sername");

                    if (CheckSimilaryFIO.Check(family, name, sername, family2, name2, sername2) == true)
                        found = true;

                   
                } //===============================================================================================
                        

                if(found == false)
                {
                    office.cell(1).Value = obj.Get("Family");
                    office.cell(2).Value = obj.Get("Name");
                    office.cell(3).Value = obj.Get("Sername");
                    office.cell(4).Value = "'" + obj.Get("Group");
                    office.toNextRow();
                }
            }

        }
    }
}
