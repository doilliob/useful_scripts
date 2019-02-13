using GIAToASURSOConverter.domain;
using GIAToASURSOConverter.forms;
using GIAToASURSOConverter.office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GIAToASURSOConverter.files
{
    class FisgiaFilesReader
    {
        // Загружает данные из файла 
        public static List<FISGIAObject> Read(String[] files)
        {
            List<FISGIAObject> FisgiaObjects = new List<FISGIAObject>();

            ExcelDocumentManager manager = new ExcelDocumentManager();
            manager.setVisible(true);
            manager.CreateExcelApplication();

            foreach (String filename in files)
            {
                //=================================
                // Открытие новой книги
                //=================================
                manager.OpenWorkbook(filename);


                //=================================
                // Подсчет количества строк
                //=================================
                manager.toFirstRow();
                manager.toNextRow();
                manager.toNextRow();
                int count = 0;
                while (!manager.empty(1))
                {
                    manager.toNextRow();
                    count++;
                }
                //=================================

                // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                /*ExcelDocumentManager manager_out = new ExcelDocumentManager();
                FISGIAObject tempObj = new FISGIAObject();
                manager_out.setVisible(true);
                manager_out.CreateExcelApplication();
                manager_out.CreateWorkbook();
                manager_out.OpenSheet();
                manager_out.toFirstRow();
                for (int i = 1; i <= tempObj.Fields().Length; i++)
                {
                    manager_out.cell(i).Value = tempObj.Description(i);
                }
                manager_out.toNextRow();*/
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                //=================================
                // Прогресс
                //=================================
                Progressor progressor = new Progressor();
                progressor.SetCount(count);
                progressor.Show();
                progressor.Focus();
                //=================================

                manager.toFirstRow();
                manager.toNextRow(); //Проскакиваем меню
                manager.toNextRow();
                while (!manager.empty(1))
                {
                    FISGIAObject obj = new FISGIAObject();

                    for (int i = 1; i <= obj.Fields().Length; i++)
                        if (!manager.empty(i))
                        {
                            if (obj.Type(i) == ParentObjectFieldTypes.DATE)
                            {
                                try
                                {
                                    obj.Set(obj.Field(i), "'" + String.Format("{0:dd.MM.yyyy}", (DateTime)manager.cell(i).Value));
                                }
                                catch (Exception e)
                                {
                                    obj.Set(obj.Field(i), null);
                                }
                            }

                            if (obj.Type(i) == ParentObjectFieldTypes.NUM)
                            {
                                try
                                {
                                    obj.Set(obj.Field(i), "'" + (manager.cell(i).Value).ToString());
                                }
                                catch (Exception e)
                                {
                                    obj.Set(obj.Field(i), null);
                                }
                            }

                            if (obj.Type(i) == ParentObjectFieldTypes.TEXT)
                            {
                                try
                                {
                                    obj.Set(obj.Field(i), (String)manager.cell(i).Value);
                                }
                                catch (Exception e)
                                {
                                    obj.Set(obj.Field(i), null);
                                }
                            }
                        }
                        else obj.Set(obj.Field(i), null);


                   FisgiaObjects.Add(obj);

                    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    /*for (int i = 1; i <= obj.Fields().Length; i++)
                    {
                        manager_out.cell(i).Value = obj.Get(i);
                    }
                    manager_out.toNextRow();*/
                    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    manager.toNextRow();
                    progressor.Step();
                } // --//-- while (!manager.empty(1))

                progressor.Hide();
                progressor.Dispose();

                manager.CloseBook();
            } // --//-- foreach (String filename in files)

            manager.CloseApplication();

            return FisgiaObjects;
        } // --//-- List<FISGIAObject> Read(String[] files)
    }
}
