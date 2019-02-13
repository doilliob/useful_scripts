using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GIAToASURSOConverter.domain
{
    class ASURSOObject : ParentObject
    {
        public ASURSOObject() : base()
        {
            this.Add("Family", "", "Фамилия", "TEXT"); //+
            this.Add("Name", "", "Имя", "TEXT"); //+
            this.Add("Sername", "", "Отчество", "TEXT");
            this.Add("DateBirth", "", "Дата рождения", "DATE");//+
            this.Add("Sex", "", "Пол", "TEXT");//+
            this.Add("SNILS", "", "СНИЛС", "TEXT");
            this.Add("Address", "", "Адрес регистрации по месту пребывания", "TEXT");
            this.Add("Finanse", "", "Финансирование", "TEXT"); //+
            this.Add("Group", "", "Группа", "TEXT"); //+
            this.Add("OrderNum", "", "№ приказа", "TEXT"); //+
            this.Add("OrderDate", "", "Дата приказа", "DATE"); //+
            this.Add("OrderBegin", "", "Действует с", "DATE"); //+
            this.Add("Reason", "", "Причина", "TEXT"); //+
            this.Add("Citizenship", "", "Гражданство", "TEXT");
            this.Add("CategoryHealth", "", "Категория здоровья", "TEXT");
            this.Add("Disability", "", "Инвалидность", "TEXT");
            this.Add("HealthGroup", "", "Группа здоровья", "TEXT");
            this.Add("PhysicalGroup", "", "Физкультурная группа", "TEXT");
            this.Add("NeedAdaptation", "", "Наличие потребности в адаптированной программе обучения", "TEXT");
            this.Add("NeedLongTreatment", "", "Наличие потребности в длительном лечении", "TEXT");
            this.Add("Education", "", "Образование", "TEXT"); //+
            this.Add("EducationFinishDate", "", "Дата окончания предыдущего обучения", "DATE"); //+
            this.Add("EducationHealthRestriction", "", "Закончил специальную организацию для учащихся с ОВЗ", "TEXT"); //+
            this.Add("EducationInternational", "", "Обучается по международному договору", "TEXT"); //+
            this.Add("AverageScore", "", "Средний балл", "TEXT");
            this.Add("Benefit", "", "Льгота", "TEXT");
            this.Add("Phone", "", "Телефон", "TEXT");
            this.Add("Email", "", "Email", "TEXT");
            this.Add("Additional", "", "Дополнительная информация", "TEXT");
            this.Add("AddressLocation", "", "Адрес проживания", "TEXT"); //+
            this.Add("DocType", "", "Тип документа", "TEXT"); //+
            this.Add("DocSer", "", "Серия паспорта", "NUM");
            this.Add("DocNum", "", "Номер паспорта", "NUM"); //+
            this.Add("DocDate", "", "Дата выдачи паспорта", "DATE"); //+
            this.Add("DocDepartment", "", "Кем выдан паспорт", "TEXT"); //+
            this.Add("DocDepartmentCode", "", "Код подразделения", "TEXT");
            this.Add("BirthAddress", "", "Место рождения", "TEXT"); //+
            this.Add("AddressRegistration", "", "Адрес регистрации", "TEXT"); //+
            this.Add("MilitaryRank", "", "Воинское звание", "TEXT");
            this.Add("MilitarySpec", "", "Военно-учётная cпециальность", "TEXT");
            this.Add("Suitability", "", "Годность к военной службе", "TEXT");
            this.Add("MilitaryGroup", "", "Группа воинского учёта", "TEXT");
            this.Add("ReserveCategory", "", "Категория запаса", "TEXT");
            this.Add("MilitarySertificate", "", "Номер военного билета", "NUM");
            this.Add("Composition", "", "Состав", "TEXT");
            this.Add("OVK", "", "Наименование отдела ОВК", "TEXT");
            this.Add("MilitaryPrepare", "", "Военная подготовка", "TEXT");
            this.Add("SpecRegistration", "", "Стоит на специальном учёте", "TEXT");
        }
    }
}
