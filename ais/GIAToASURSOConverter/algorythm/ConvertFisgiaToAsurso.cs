using GIAToASURSOConverter.domain;
using GIAToASURSOConverter.log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GIAToASURSOConverter.algorythm
{
    class ConvertFisgiaToAsurso
    {
        // Конвертирует один объект в АСУ РСО
        public static ASURSOObject ConvertToASURSOObject(FISGIAObject element)
        {
            // Если студент поступил и есть в группе, иначе возвращается ноль - обработка студента не имеет смысла
            knowlege.ArrivedStudentsKnowlege knowlege = new GIAToASURSOConverter.knowlege.ArrivedStudentsKnowlege();
            String group = knowlege.getGroup(
                element.Get("Family"), element.Get("Name"), element.Get("Sername"));
            if (group == null)
            {
                Logger.getInstance().log("Студент не найден " + element.Get("Family") + " " + element.Get("Name") + " " + element.Get("Sername"));
                return null;
            }

            // Платно
            bool isCommerce = knowlege.ifCommerce(group);

            ASURSOObject rso_object = new ASURSOObject();
            // "Family" - "Фамилия" //+
            rso_object.Set("Family", element.Get("Family"));
            // "Name" - "Имя" //+
            rso_object.Set("Name", element.Get("Name"));
            // "Sername" - "Отчество"
            rso_object.Set("Sername", element.Get("Sername"));
            // "DateBirth" - "Дата рождения"//+
            rso_object.Set("DateBirth", element.Get("BirthDate"));
            // "Sex" - "Пол"//+
            rso_object.Set("Sex", element.Get("Sex").Contains("Женский") ? "Женский" : "Мужской");

            // "Finanse" - "Финансирование" //+
            rso_object.Set("Finanse", isCommerce ? "За счет физического лица" : "За счет бюджета субъекта РФ");
            // "Group" - "Группа" //+
            rso_object.Set("Group", group);

            // "OrderNum" - "№ приказа" //+
            rso_object.Set("OrderNum", global.GlobalSettings.ORDER_NUM);
            // "OrderDate" - "Дата приказа" //+
            rso_object.Set("OrderDate", global.GlobalSettings.ORDER_DATE);
            // "OrderBegin" - "Действует с" //+
            rso_object.Set("OrderBegin", global.GlobalSettings.ORDER_BEGIN);

            // "Reason" - "Причина" //+
            rso_object.Set("Reason", "По среднему баллу аттестата");
            // "Education" - "Образование" //+

            // "EducationFinishDate" - "Дата окончания предыдущего обучения" //+
            rso_object.Set("EducationFinishDate", element.Get("EDocDate"));

            // "EducationHealthRestriction" - "Закончил специальную организацию для учащихся с ОВЗ" //+
            rso_object.Set("EducationHealthRestriction", "Нет");

            // "EducationInternational" - "Обучается по международному договору" //+
            rso_object.Set("EducationInternational", "Нет");

            // ЕСЛИ НЕ ИНОСТРАННЫЙ ГРАЖДАНИН С ЗАПОЛНЕННЫМ ПАСПОРТОМ
            // ИНАЧА ЛУЧШЕ НИЧЕГО НЕ ВБИВАТЬ
            if ((element.Get("DocType") == "Паспорт гражданина РФ") &&
                (element.Get("DocSer").Length == 4) &&
                (element.Get("DocNum").Length == 6))
            {
                // "AddressLocation" - "Адрес проживания" //+
                rso_object.Set("AddressLocation", element.Get("Address"));
                // "DocType" - "Тип документа" //+
                rso_object.Set("DocType", "Паспорт РФ");
                // "DocSer" - "Серия паспорта"
                rso_object.Set("DocSer", element.Get("DocSer"));
                // "DocNum" - "Номер паспорта" //+
                rso_object.Set("DocNum", element.Get("DocNum"));
                // "DocDate" - "Дата выдачи паспорта" //+
                rso_object.Set("DocDate", element.Get("DocDate"));
                // "DocDepartment" - "Кем выдан паспорт" //+
                rso_object.Set("DocDepartment", element.Get("DocDepartment"));
                // "BirthAddress" - "Место рождения" //+
                rso_object.Set("BirthAddress", element.Get("BirthAddress"));
                // "AddressRegistration" - "Адрес регистрации" //+
                rso_object.Set("AddressRegistration", element.Get("Address"));
            }


            return rso_object;
        }
    }
}
