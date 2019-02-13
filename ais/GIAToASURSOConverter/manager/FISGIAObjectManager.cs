using GIAToASURSOConverter.algorythm;
using GIAToASURSOConverter.domain;
using GIAToASURSOConverter.files;
using GIAToASURSOConverter.forms;
using GIAToASURSOConverter.knowlege;
using GIAToASURSOConverter.log;
using GIAToASURSOConverter.office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIAToASURSOConverter.manager
{
    class FISGIAObjectManager
    {
        // Коллекция загруженных из файла объектов
        private List<FISGIAObject> objects;
        
        
        public FISGIAObjectManager()
        {
            this.objects = new List<FISGIAObject>();
        }

        // Загружает данные из файла 
        public void LoadFiles()
        {
            String[] files = ExcelFilesChooser.Choose();
            if (files == null)
            {
                MessageBox.Show("Ошибка! Ни один файл не выбран!");
                return;
            }
            this.objects = FisgiaFilesReader.Read(files);
        }

        // Выводит весь список загруженных студентов
        public List<FISGIAObject> getAll()
        {
            return this.objects;
        }
        // Выводит объекты в Excel файл
        public void printAllToExcel()
        {
            ExcelDocumentManager manager_out = new ExcelDocumentManager();
            manager_out.setVisible(true);
            manager_out.CreateExcelApplication();
            manager_out.CreateWorkbook();
            manager_out.OpenSheet();
            manager_out.toFirstRow();

            // Выводим шапку
            FISGIAObject tempObj = new FISGIAObject();
            for (int i = 1; i <= tempObj.Fields().Length; i++)
                manager_out.cell(i).Value = tempObj.Description(i);
            manager_out.toNextRow();

            // Выводим объекты
            foreach(FISGIAObject obj in this.objects)
            {
                for (int i = 1; i <= obj.Fields().Length; i++)
                {
                    manager_out.cell(i).Value = obj.Get(i);
                }
                manager_out.toNextRow();
            }
            
        } //--//--

        public List<FISGIAObject> getArrived()
        {
            List<FISGIAObject> arrvd = new List<FISGIAObject>();

            GIAToASURSOConverter.knowlege.ArrivedStudentsKnowlege knowlege = new GIAToASURSOConverter.knowlege.ArrivedStudentsKnowlege();
            foreach(ArrivedStudentObject st in knowlege.getAll())
            {
                FISGIAObject obj = null;
                foreach(FISGIAObject student in this.objects)
                {
                    if (CheckSimilaryFIO.Check(
                        student.Get("Family"), student.Get("Name"), student.Get("Sername"),
                        st.Get("Family"), st.Get("Name"), st.Get("Sername")))
                        obj = student;
                }
                if (obj != null)
                    arrvd.Add(obj);
            }
            
            return arrvd;
        }

        public List<ASURSOObject> getAllArrived()
        {
            List<FISGIAObject> arrvd = this.getArrived();
            List<ASURSOObject> lst = new List<ASURSOObject>();
            foreach (FISGIAObject obj in arrvd)
                lst.Add(ConvertFisgiaToAsurso.ConvertToASURSOObject(obj));
            return lst;
        }


      

        // Конвертирует в объекты АСУ РСО все объекты из ФИС ГИА
        public List<ASURSOObject> ConvertAllToASURSO(List<FISGIAObject> elms)
        {
            List<ASURSOObject> objs = new List<ASURSOObject>();
            foreach (FISGIAObject fobj in elms)
            {
                ASURSOObject aobj = ConvertFisgiaToAsurso.ConvertToASURSOObject(fobj);
                if (aobj != null)
                    objs.Add(aobj);
            }
            return objs;
        }

        public List<ASURSOObject> ConvertAllToASURSO()
        {
            return this.ConvertAllToASURSO(this.objects);
        }

        public int getCount() { return this.objects.Count(); }
        
    }
}
