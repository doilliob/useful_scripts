using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GIAToASURSOConverter.domain
{
    class FISGIAObject : ParentObject
    {
        public FISGIAObject() : base()
        {
            this.Add("DateRegistration", "", "Дата Регистрации", "DATE");
            this.Add("StatementNum", "", "Номер заявления (Строка)", "NUM");
            this.Add("ConcursGroup", "", "Конкурсная группа", "TEXT");
            this.Add("Family", "", "Фамилия", "TEXT"); //+
            this.Add("Name", "", "Имя", "TEXT"); //+
            this.Add("Sername", "", "Отчество", "TEXT"); //+
            this.Add("Sex", "", "Пол", "TEXT"); //+
            this.Add("Region", "", "Регион", "TEXT");
            this.Add("Locality", "", "Тип населенного пункта", "TEXT");
            this.Add("Address", "", "Адрес проживания (строка)", "TEXT"); //+
            this.Add("DateOriginals", "", "Дата подачи оригиналов", "DATE");
            this.Add("DocType", "", "Вид документа", "TEXT"); //+
            this.Add("CitizenShip", "", "Гражданство", "TEXT"); //+
            this.Add("DocSer", "", "Серия", "NUM"); //+
            this.Add("DocNum", "", "Номер", "NUM"); //+
            this.Add("DocDepartmentNum", "", "Подразделение", "TEXT"); //+
            this.Add("DocDepartment", "", "Кем выдан", "TEXT"); //+
            this.Add("DocDate", "", "Когда", "DATE"); //+
            this.Add("BirthDate", "", "Дата рождения", "DATE"); //+
            this.Add("BirthAddress", "", "Место рождения", "TEXT"); //+
            this.Add("EDocType", "", "Вид документа", "TEXT");
            this.Add("EDocDateOriginal", "", "Дата предоставления оригиналов", "DATE");
            this.Add("EDocSer", "", "Серия", "NUM");
            this.Add("EDocNum", "", "Номер", "NUM");
            this.Add("EDocDate", "", "Дата выдачи", "DATE"); //+
            this.Add("EDocRegNum", "", "Регистрационный номер", "TEXT");
            this.Add("EDocEnding", "", "Год окончания", "NUM");
            this.Add("AverageScore", "", "Средний балл", "NUM");
        }

    }
}
