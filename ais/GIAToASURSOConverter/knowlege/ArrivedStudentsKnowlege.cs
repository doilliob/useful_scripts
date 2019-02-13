using GIAToASURSOConverter.algorythm;
using GIAToASURSOConverter.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GIAToASURSOConverter.knowlege
{
    class ArrivedStudentsKnowlege
    {
        private List<ArrivedStudentObject> list;
        public ArrivedStudentsKnowlege()
        {
            this.list = new List<ArrivedStudentObject>();
            
            // Заполнить 2018 год
            this.pleaseFill2018();    

        }
        

       

        public String getGroup(String family, String name, String sername)
        {
            ArrivedStudentObject obj = null;
            foreach (ArrivedStudentObject o in this.list)
                if (CheckSimilaryFIO.Check(o.Get("Family"), o.Get("Name"), o.Get("Sername"), family, name, sername))
                    obj = o;
            
            return (obj == null) ? null : obj.Get("Group");
        }

        public bool ifCommerce(String group)
        {
            return this.pleaseCommerce2018(group);
        }

        public List<ArrivedStudentObject> getAll() { return this.list;  }
        /** 
         * ================================================
         * ДАННЫЕ
         * ================================================
         */

        //=================================================
        // 2018
        //=================================================

        private void pleaseFill2018()
        {
            ArrivedStudentObject obj = new ArrivedStudentObject();
            obj.Set("Family", "Агаркова");
            obj.Set("Name", "Маргарита");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Власенко");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гайнуллина");
            obj.Set("Name", "Алеся");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гатагажева");
            obj.Set("Name", "Тамила");
            obj.Set("Sername", "Эльдаровна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гоненко");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Демирова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Зейнутдиновна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Евдокимова");
            obj.Set("Name", "Кристина");
            obj.Set("Sername", "Ивановна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Евсеева");
            obj.Set("Name", "Галина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Жаркова");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Антоновна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Журавель");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зубряева");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кирочкина");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ковыляцких");
            obj.Set("Name", "Евгения");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кокарева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сернова");
            obj.Set("Name", "Ксения");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мозгушина");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мурзабаева");
            obj.Set("Name", "Камила");
            obj.Set("Sername", "Наурзбаевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Непогожева");
            obj.Set("Name", "Оксана");
            obj.Set("Sername", "Васильевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Одинокова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сапукова");
            obj.Set("Name", "Элина");
            obj.Set("Sername", "Рамилевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Скрипкина");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сямина");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Аркадьевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Чикина");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шаляпина");
            obj.Set("Name", "Регина");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Эрбоева");
            obj.Set("Name", "Ануша");
            obj.Set("Sername", "Анхоровна");
            obj.Set("Group", "0131");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Басова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0132");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Винокурова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0132");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гайсина");
            obj.Set("Name", "София");
            obj.Set("Sername", "Маратовна");
            obj.Set("Group", "0132");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Грибанова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0132");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ермолаева");
            obj.Set("Name", "Диана");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0132");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Козлова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0132");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Коншина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0132");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Костяева");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0132");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Хужаназарова");
            obj.Set("Name", "Мадинабону");
            obj.Set("Sername", "Бахтиёр");
            obj.Set("Group", "0132");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абзяпбарова");
            obj.Set("Name", "Инзиля");
            obj.Set("Sername", "Халилевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ахметгалиев");
            obj.Set("Name", "Ильнур");
            obj.Set("Sername", "Ильдусович");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Белов");
            obj.Set("Name", "Данил");
            obj.Set("Sername", "Романович");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Богатова");
            obj.Set("Name", "Полина");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Богатырева");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Войнова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Назаровна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Волкова");
            obj.Set("Name", "Ангелина");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Деревянкина");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Евгениевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Джовбатырова");
            obj.Set("Name", "Марьям");
            obj.Set("Sername", "Усмановна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Калашникова");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Качанович");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кривцов");
            obj.Set("Name", "Дмитрий");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кугураков");
            obj.Set("Name", "Юрий");
            obj.Set("Sername", "Николаевич");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Макеева");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Медетова");
            obj.Set("Name", "Дина");
            obj.Set("Sername", "Муратовна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Небогина");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Никонова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Орехова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Павлова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Петров");
            obj.Set("Name", "Савелий");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Попова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сквозников");
            obj.Set("Name", "Даниил");
            obj.Set("Sername", "Дмитриевич");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Хусаинов");
            obj.Set("Name", "Никита");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шмонина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Юсупов");
            obj.Set("Name", "Фанис");
            obj.Set("Sername", "Рямисович");
            obj.Set("Group", "0111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ахмедова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бакланова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бахарева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Ивановна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Белолипецких");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Волкова");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Григорьевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гладышева");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гундарева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Журавлева");
            obj.Set("Name", "Руслана");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зиновьева");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ключникова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кожевников");
            obj.Set("Name", "Антон");
            obj.Set("Sername", "Георгиевич");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Комолова");
            obj.Set("Name", "Самида");
            obj.Set("Sername", "Азатовна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кочеткова");
            obj.Set("Name", "Варвара");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лящук");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мыцыкова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Назарова");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ненашева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Орлова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Самарцева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сярдова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ташимбаева");
            obj.Set("Name", "Нулуфархан");
            obj.Set("Sername", "Улукбековна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Терновская");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Артуровна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Уварова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Штанько");
            obj.Set("Name", "Влада");
            obj.Set("Sername", "Вадимовна");
            obj.Set("Group", "0112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аистова");
            obj.Set("Name", "Эльвира");
            obj.Set("Sername", "Эдуардовна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ананенко");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бадаева");
            obj.Set("Name", "Кристина");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Быкова");
            obj.Set("Name", "Иулиана");
            obj.Set("Sername", "Максимовна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гараев");
            obj.Set("Name", "Руслан");
            obj.Set("Sername", "Айратович");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ермолаева");
            obj.Set("Name", "Полина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Керимова");
            obj.Set("Name", "Айшан");
            obj.Set("Sername", "Булуд");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Клокова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Комарчева");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кушманова");
            obj.Set("Name", "Арина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мовсисян");
            obj.Set("Name", "Левон");
            obj.Set("Sername", "Арменович");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Машкова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Муханова");
            obj.Set("Name", "Ксения");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Окладова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Олисов");
            obj.Set("Name", "Демид");
            obj.Set("Sername", "Федорович");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пашутин");
            obj.Set("Name", "Игорь");
            obj.Set("Sername", "Евгеньевич");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Попельнюк");
            obj.Set("Name", "Елизавета");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Семикова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Серяков");
            obj.Set("Name", "Иван");
            obj.Set("Sername", "Станиславович");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Строкова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сысоева");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Схулухия");
            obj.Set("Name", "Гиорги");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тюмкина");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Константиновна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Фатеева");
            obj.Set("Name", "Кристина");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Харитонова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абдрашитова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Рамильевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абизяева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Андреев");
            obj.Set("Name", "Василий");
            obj.Set("Sername", "Андреевич");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Белоглазова");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Березина");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Борисова");
            obj.Set("Name", "Елизавета");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бырлат");
            obj.Set("Name", "Полина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Быченина");
            obj.Set("Name", "Софья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Васильева");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Виснап");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Антоновна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Влазнев");
            obj.Set("Name", "Данил");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Волкова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Горбунова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Дасаева");
            obj.Set("Name", "Зимфира");
            obj.Set("Sername", "Рафаэлевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Долгинина");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Емелина");
            obj.Set("Name", "Виолетта");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Емельянова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Жукова");
            obj.Set("Name", "Ангелина");
            obj.Set("Sername", "Львовна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Иванова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Исаева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кадящева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Никитина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Панкова");
            obj.Set("Name", "Арина");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Свитова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Павловна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Солдаткина");
            obj.Set("Name", "Софья");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "0114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Александрова");
            obj.Set("Name", "Надежда");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Андреева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бажинова");
            obj.Set("Name", "Валентина");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Будаева");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Власова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Вадимовна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Волкова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Долгишева");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Максимовна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Еркалиева");
            obj.Set("Name", "Айгуль");
            obj.Set("Sername", "Кинжегалиевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зрелова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Иманалиева");
            obj.Set("Name", "Джамиля");
            obj.Set("Sername", "Куанышбаевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карташова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Коновалов");
            obj.Set("Name", "Евгений");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кривоноженко");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Даниловна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Макарова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мальчикова");
            obj.Set("Name", "Анжелика");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Милюкова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Морозова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мочальникова");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Никитин");
            obj.Set("Name", "Илья");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пайбаршева");
            obj.Set("Name", "Арина");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Петрова");
            obj.Set("Name", "Софья");
            obj.Set("Sername", "Ивановна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сернова");
            obj.Set("Name", "Ксения");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Стожарова");
            obj.Set("Name", "Даниела");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Хабибуллина");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шмойлова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Антонова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Арисов");
            obj.Set("Name", "Святослав");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Вострецова");
            obj.Set("Name", "Кристина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гаврилова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Григорьева");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Дробышева");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ибраимова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Эдуардовна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Касумова");
            obj.Set("Name", "Первин");
            obj.Set("Sername", "Асифовна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кочергина");
            obj.Set("Name", "София");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Краснова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Федоровна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кулебякина");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Максимова");
            obj.Set("Name", "Вероника");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Малышева");
            obj.Set("Name", "Арина");
            obj.Set("Sername", "Владиславовна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Морозова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Денисовна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Нардина");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Николаева");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Патрухин");
            obj.Set("Name", "Валентин");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Перваков");
            obj.Set("Name", "Дамир");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пронина");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Седова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Смолякова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сорокина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Суханкина");
            obj.Set("Name", "Алена");
            obj.Set("Sername", "Павловна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шухрова");
            obj.Set("Name", "Вероника");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Яковлева");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Артамонова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аскерова");
            obj.Set("Name", "Севинж");
            obj.Set("Sername", "Бейдуллакызы");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гаджикеримова");
            obj.Set("Name", "Ансият");
            obj.Set("Sername", "Рейзудиновна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Городницина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Константиновна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Городницина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Константиновна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Исаева");
            obj.Set("Name", "Елизавета");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Котова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кривенко");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Макишева");
            obj.Set("Name", "Альбина");
            obj.Set("Sername", "Раилевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Матаева");
            obj.Set("Name", "Иман-Ирс");
            obj.Set("Sername", "Абдул-Хадиевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Миракова");
            obj.Set("Name", "Ситора");
            obj.Set("Sername", "Зувайдулловна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мифтахова");
            obj.Set("Name", "Диляра");
            obj.Set("Sername", "Ринатовна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Наумова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Никонова");
            obj.Set("Name", "Ангелина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пелевина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Перкакуева");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Редькин");
            obj.Set("Name", "Сергей");
            obj.Set("Sername", "Витальевич");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Стрельцова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тараскин");
            obj.Set("Name", "Владимир");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тафеева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Устимова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Фролов");
            obj.Set("Name", "Петр");
            obj.Set("Sername", "Петрович");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Харченко");
            obj.Set("Name", "Василиса");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шафигуллина");
            obj.Set("Name", "Лилия");
            obj.Set("Sername", "Наилевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шишова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ахадова");
            obj.Set("Name", "Найля");
            obj.Set("Sername", "Азеровна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Евтюнина");
            obj.Set("Name", "Полина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зяблова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Калентьева");
            obj.Set("Name", "Алена");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карякина");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Косырева");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Криворучкина");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ларькова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Матяшова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Михалкина");
            obj.Set("Name", "Милена");
            obj.Set("Sername", "Валентиновна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Немчинова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Станиславовна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Новахатская");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Писарева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рогова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Саненкова");
            obj.Set("Name", "Ангелина");
            obj.Set("Sername", "Романовна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Синицына");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Страмнова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сумина");
            obj.Set("Name", "Ульяна");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Терехина");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тюгаева");
            obj.Set("Name", "Елизавета");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Фадина");
            obj.Set("Name", "Ангелина");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Чернова");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Владиславовна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шалыгина");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шкоденко");
            obj.Set("Name", "Василий");
            obj.Set("Sername", "Алексеевич");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шоева");
            obj.Set("Name", "Лайло");
            obj.Set("Sername", "Мирхужаевна");
            obj.Set("Group", "0118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Егорникова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зенкова");
            obj.Set("Name", "Виталина");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Игнатенко");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Комарова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Королева");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кочеткова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кудряшова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лемкова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Малахова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мачкавская");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Михеева");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Вадимовна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Молодкина");
            obj.Set("Name", "Олеся");
            obj.Set("Sername", "Павловна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Неманова");
            obj.Set("Name", "Ксения");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Оплетаева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Орлова");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Борисовна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Романова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сафронова");
            obj.Set("Name", "Оксана");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Силина");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сураева");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тупова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Удиванкина");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Чистякова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шадманова");
            obj.Set("Name", "Нозанин");
            obj.Set("Sername", "Муродовна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шмелева");
            obj.Set("Name", "Олеся");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Юшкина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0119");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абаева");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абрамянц");
            obj.Set("Name", "Элена");
            obj.Set("Sername", "Тиграновна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Баженов");
            obj.Set("Name", "Василий");
            obj.Set("Sername", "Андреевич");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Вырлова");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гафурова");
            obj.Set("Name", "Алия");
            obj.Set("Sername", "Айзатовна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Дегтярева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Васильевна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Забалуева");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Игнатова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карпинский");
            obj.Set("Name", "Данила");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Козюлова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Круглова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Максимовна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Крутов");
            obj.Set("Name", "Михаил");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кульджанова");
            obj.Set("Name", "Сауле");
            obj.Set("Sername", "Сагадатовна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лялькин");
            obj.Set("Name", "Александр");
            obj.Set("Sername", "Станиславович");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Михайлова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Назарова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Орипов");
            obj.Set("Name", "Джасурбек");
            obj.Set("Sername", "Саидович");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Петракович");
            obj.Set("Name", "Артем");
            obj.Set("Sername", "Георгиевич");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рзаев");
            obj.Set("Name", "Рашид");
            obj.Set("Sername", "Натигоглы");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тишина");
            obj.Set("Name", "Виталия");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Петров");
            obj.Set("Name", "Егор");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Русстамов");
            obj.Set("Name", "Ринат");
            obj.Set("Sername", "Рахматуллаевич");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Холматова");
            obj.Set("Name", "Хамидахон");
            obj.Set("Sername", "Умидовна");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шыхалыева");
            obj.Set("Name", "Нахида");
            obj.Set("Sername", "Искендеркызы");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Яшин");
            obj.Set("Name", "Артем");
            obj.Set("Sername", "Андреевич");
            obj.Set("Group", "0120");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Андриевская");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Безугла");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Безугла");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гаффорова");
            obj.Set("Name", "Шахзода");
            obj.Set("Sername", "Мавлоновна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гукасян");
            obj.Set("Name", "Рузанна");
            obj.Set("Sername", "Руслановна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гукасян");
            obj.Set("Name", "Рузанна");
            obj.Set("Sername", "Руслановна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Исаева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Калашников");
            obj.Set("Name", "Артем");
            obj.Set("Sername", "Максимович");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Калашников");
            obj.Set("Name", "Артем");
            obj.Set("Sername", "Максимович");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Крашенинникова");
            obj.Set("Name", "Диана");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кузина");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кулинченко");
            obj.Set("Name", "Матвей");
            obj.Set("Sername", "Юрьевич");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мараджабов");
            obj.Set("Name", "Джахонгир");
            obj.Set("Sername", "Рахмонович");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мельник");
            obj.Set("Name", "Вадим");
            obj.Set("Sername", "Дмитриевич");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Норкулова");
            obj.Set("Name", "Лайло");
            obj.Set("Sername", "Орифжоновна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Одинокова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Станиславовна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пономарева");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Петрова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рыбинская");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Салиева");
            obj.Set("Name", "Нозимахон");
            obj.Set("Sername", "Адилжановна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тихомирова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Холова");
            obj.Set("Name", "Лайли");
            obj.Set("Sername", "Баходурджоновна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Хусанова");
            obj.Set("Name", "Фарахноз");
            obj.Set("Sername", "Нуралиевна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Явкина");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ган");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "0122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Семенова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "0122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Нерсесян");
            obj.Set("Name", "Снежана");
            obj.Set("Sername", "Саркисовна");
            obj.Set("Group", "0122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Баландинская");
            obj.Set("Name", "София");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Беспалова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Вавиличева");
            obj.Set("Name", "Кристина");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Воловик");
            obj.Set("Name", "Алексей");
            obj.Set("Sername", "Андреевич");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Галеева");
            obj.Set("Name", "Эльвира");
            obj.Set("Sername", "Зарифовна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Жилюнова");
            obj.Set("Name", "Лилия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Касимова");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Корчагина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Павловна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Малышкина");
            obj.Set("Name", "Кира");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мельникова");
            obj.Set("Name", "Софья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Новикова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Орехова");
            obj.Set("Name", "Елизавета");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Павлова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Проценко");
            obj.Set("Name", "Анфиса");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рудакова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рустамова");
            obj.Set("Name", "Малика");
            obj.Set("Sername", "Сухробовна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рябченко");
            obj.Set("Name", "Олеся");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сафронова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сергеева");
            obj.Set("Name", "Вероника");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Умарова");
            obj.Set("Name", "Милана");
            obj.Set("Sername", "Вадимовна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Холодова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Цветков");
            obj.Set("Name", "Максим");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шигапова");
            obj.Set("Name", "Эльвина");
            obj.Set("Sername", "Раилевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Щербакова");
            obj.Set("Name", "Карина");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ямщикова");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0141");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ахвердян");
            obj.Set("Name", "Каринэ");
            obj.Set("Sername", "Арменовна");
            obj.Set("Group", "0142");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бутакова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Антоновна");
            obj.Set("Group", "0142");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Глушань");
            obj.Set("Name", "Егор");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "0142");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ильина");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "0142");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кривова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0142");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Манучарян");
            obj.Set("Name", "Гарик");
            obj.Set("Sername", "Эдуардович");
            obj.Set("Group", "0142");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пархоменко");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0142");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сивова");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0142");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абакумова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Артемьева");
            obj.Set("Name", "Вероника");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Валиева");
            obj.Set("Name", "Алсу");
            obj.Set("Sername", "Шамилевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Галстьян");
            obj.Set("Name", "Степан");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гладкова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Давыдова");
            obj.Set("Name", "Ксения");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Демешко");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Добровольский");
            obj.Set("Name", "Виктор");
            obj.Set("Sername", "Андреевич");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Жукова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зотанина");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кугушев");
            obj.Set("Name", "Андрей");
            obj.Set("Sername", "Игоревич");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лустенков");
            obj.Set("Name", "Михаил");
            obj.Set("Sername", "Алексеевич");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Меркулова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Минеева");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Назарова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Петровна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Новосельцева");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Поликарпова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пятачкова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Семерозубова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сергеева");
            obj.Set("Name", "Ксения");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сернов");
            obj.Set("Name", "Арсений");
            obj.Set("Sername", "Николаевич");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Слепов");
            obj.Set("Name", "Никита");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Степнова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ткаченко");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Марковна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Фроликова");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Агамиева");
            obj.Set("Name", "Сабира");
            obj.Set("Sername", "Матлабкызы");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Алмардонова");
            obj.Set("Name", "София");
            obj.Set("Sername", "Журабековна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Борисова");
            obj.Set("Name", "Диана");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Войтова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Галимова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Рафаэлевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Давлатов");
            obj.Set("Name", "Мухаммадджон");
            obj.Set("Sername", "Мусаябович");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Девяткина");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Владиславовна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Демина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Драчева");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Драчева");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Иванченкова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Климова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лаврентьева");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Антоновна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мазанова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Константиновна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Махмадиева");
            obj.Set("Name", "Маликахон");
            obj.Set("Sername", "Саидакбаровна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Махфирова");
            obj.Set("Name", "Хамидахон");
            obj.Set("Sername", "Рустамовна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Насырова");
            obj.Set("Name", "Альфия");
            obj.Set("Sername", "Дарисовна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Нумонова");
            obj.Set("Name", "Шахноза");
            obj.Set("Sername", "Бахтиёровна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рагулина");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рахимов");
            obj.Set("Name", "Комрон");
            obj.Set("Sername", "Комилович");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Садибоева");
            obj.Set("Name", "Махина");
            obj.Set("Sername", "Чамшедовна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сулаймонова");
            obj.Set("Name", "Бунафша");
            obj.Set("Sername", "Амруллоевна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Фартдинова");
            obj.Set("Name", "Регина");
            obj.Set("Sername", "Фанисовна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Циденкова");
            obj.Set("Name", "Владислава");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шарипов");
            obj.Set("Name", "Парвиз");
            obj.Set("Sername", "Ахрорович");
            obj.Set("Group", "0162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Артюшкина");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аюпова");
            obj.Set("Name", "Марьям");
            obj.Set("Sername", "Ильдаровна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бояркин");
            obj.Set("Name", "Данила");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Воробьев");
            obj.Set("Name", "Максим");
            obj.Set("Sername", "Дмитриевич");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гальченко");
            obj.Set("Name", "Карина");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Григорьева");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Дегтярев");
            obj.Set("Name", "Кирилл");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Десятова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ергунева");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зеленцова");
            obj.Set("Name", "Олеся");
            obj.Set("Sername", "Максимовна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карцева");
            obj.Set("Name", "Полина");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Крупник");
            obj.Set("Name", "Кристина");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лачугина");
            obj.Set("Name", "Валентина");
            obj.Set("Sername", "Павловна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мамедова");
            obj.Set("Name", "Нурана");
            obj.Set("Sername", "Самилкызы");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мирзаева");
            obj.Set("Name", "Рузахан");
            obj.Set("Sername", "Сирожиддиновна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мухамбетова");
            obj.Set("Name", "Эльмира");
            obj.Set("Sername", "Захаровна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Озерова");
            obj.Set("Name", "Нигина");
            obj.Set("Sername", "Валентиновна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Осначенко");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Савин");
            obj.Set("Name", "Денис");
            obj.Set("Sername", "Евгеньевич");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Смирнов");
            obj.Set("Name", "Николай");
            obj.Set("Sername", "Андреевич");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Софронова");
            obj.Set("Name", "Диана");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тимиргалеева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Альбертовна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Федоровских");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Фомичева");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Максимовна");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Черепанов");
            obj.Set("Name", "Леонид");
            obj.Set("Sername", "Витальевич");
            obj.Set("Group", "0163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бизяева");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Каюмова");
            obj.Set("Name", "Лайло");
            obj.Set("Sername", "Займиддинова");
            obj.Set("Group", "0164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Полозова");
            obj.Set("Name", "Елизавета");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Токарева");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "0164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Уварова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Феоктистова");
            obj.Set("Name", "Арина");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "0164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Чаплыгина");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "0164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Якубжанова");
            obj.Set("Name", "Муслимахон");
            obj.Set("Sername", "Азамжоновна");
            obj.Set("Group", "0164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ярыгина");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "0164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Алаев");
            obj.Set("Name", "Александр");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Драп");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Станиславовна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бабаян");
            obj.Set("Name", "Лаура");
            obj.Set("Sername", "Вруйровна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Белоусова");
            obj.Set("Name", "Софья");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Босова");
            obj.Set("Name", "Евгения");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Витяева");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Горбушина");
            obj.Set("Name", "Элина");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Джалладян");
            obj.Set("Name", "Эмма");
            obj.Set("Sername", "Гайказовна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Караханян");
            obj.Set("Name", "Галина");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Крупнина");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кудинов");
            obj.Set("Name", "Сергей");
            obj.Set("Sername", "Олегович");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кузнецов");
            obj.Set("Name", "Александр");
            obj.Set("Sername", "Максимович");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Курлин");
            obj.Set("Name", "Иван");
            obj.Set("Sername", "Алексеевич");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Магомедрасулова");
            obj.Set("Name", "Ханзаза");
            obj.Set("Sername", "Магомедрасуловна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Михайлова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Денисовна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Николаева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Паймушкин");
            obj.Set("Name", "Андрей");
            obj.Set("Sername", "Алексеевич");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пидюрчина");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сергеева");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Силянова");
            obj.Set("Name", "Елизавета");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Трофименко");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тукмакова");
            obj.Set("Name", "Ксения");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Фролова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шарафутдинова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Равилевна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шемякина");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "1121");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Акельев");
            obj.Set("Name", "Юрий");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Афонькина");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бабуль");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Петровна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Барманова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Газимагомедова");
            obj.Set("Name", "Саида");
            obj.Set("Sername", "Асадулаевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Асяева");
            obj.Set("Name", "Валентина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Климова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Королева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Куликов");
            obj.Set("Name", "Дмитрий");
            obj.Set("Sername", "Андреевич");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лужнов");
            obj.Set("Name", "Антон");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Масловская");
            obj.Set("Name", "Злата");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Никишкина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Окатьева");
            obj.Set("Name", "Алена");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Подорожный");
            obj.Set("Name", "Максим");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Прокаева");
            obj.Set("Name", "Вероника");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Савенкова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Секуняева");
            obj.Set("Name", "Снежана");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Семенова");
            obj.Set("Name", "Елизавета");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сергеев");
            obj.Set("Name", "Андрей");
            obj.Set("Sername", "Иванович");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Терентьева");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ткач");
            obj.Set("Name", "Олеся");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Халимова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Рафиковна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шарипова");
            obj.Set("Name", "Маргарита");
            obj.Set("Sername", "Фаилевна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шелтыганова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Ивановна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Яковлева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "1122");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абдульмянова");
            obj.Set("Name", "Гузяль");
            obj.Set("Sername", "Ахмядиевна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Алтухов");
            obj.Set("Name", "Сергей");
            obj.Set("Sername", "Романович");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Альп");
            obj.Set("Name", "Диана");
            obj.Set("Sername", "Байрамовна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бигильдин");
            obj.Set("Name", "Александр");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Воротников");
            obj.Set("Name", "Артем");
            obj.Set("Sername", "Вячеславович");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гордеева");
            obj.Set("Name", "Валентина");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гуриненко");
            obj.Set("Name", "Надежда");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Жирнова");
            obj.Set("Name", "Ангелина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кинзикеева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Колесникова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Петровна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кудряшова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кульмякова");
            obj.Set("Name", "Владлена");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мидонов");
            obj.Set("Name", "Константин");
            obj.Set("Sername", "Игоревич");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Моисеева");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Плешакова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пятницкая");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рыбакова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шафикова");
            obj.Set("Name", "Сабина");
            obj.Set("Sername", "Маратовна");
            obj.Set("Group", "1123");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абдурахмонов");
            obj.Set("Name", "Дилербек");
            obj.Set("Sername", "Гуломкодирович");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бахарева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Антоновна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бекетова");
            obj.Set("Name", "Софья");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гареева");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Руслановна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Горбачева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Давыдова");
            obj.Set("Name", "Нина");
            obj.Set("Sername", "Петровна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Земскова");
            obj.Set("Name", "Вера");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карнаухов");
            obj.Set("Name", "Василий");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карпова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кондраткова");
            obj.Set("Name", "Антонина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кораблева");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лагутин");
            obj.Set("Name", "Дмитрий");
            obj.Set("Sername", "Николаевич");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Малкина");
            obj.Set("Name", "Арина");
            obj.Set("Sername", "Антоновна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Матвеева");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Окольнов");
            obj.Set("Name", "Владислав");
            obj.Set("Sername", "Игоревич");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Попова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ракшаева");
            obj.Set("Name", "Людмила");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рашидова");
            obj.Set("Name", "Фатима");
            obj.Set("Sername", "Сабировна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рулла");
            obj.Set("Name", "Анжелика");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сиротина");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Скорая");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Таирова");
            obj.Set("Name", "Карина");
            obj.Set("Sername", "Батыровна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Щегольков");
            obj.Set("Name", "Иван");
            obj.Set("Sername", "Алексеевич");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Михайлова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мухутдинова");
            obj.Set("Name", "Полина");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "1124");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абрамова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Агапов");
            obj.Set("Name", "Артем");
            obj.Set("Sername", "Алексеевич");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бережнов");
            obj.Set("Name", "Данила");
            obj.Set("Sername", "Станиславович");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Васильева");
            obj.Set("Name", "Софья");
            obj.Set("Sername", "Вадимовна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Галстян");
            obj.Set("Name", "Гагик");
            obj.Set("Sername", "Самвелович");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гусейнов");
            obj.Set("Name", "Эмин");
            obj.Set("Sername", "Джошгун");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Землянова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кабакова");
            obj.Set("Name", "Асима");
            obj.Set("Sername", "Ислямгалиевна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карбовских");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Колганова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Крючков");
            obj.Set("Name", "Глеб");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кузьмин");
            obj.Set("Name", "Никита");
            obj.Set("Sername", "Анатольевич");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кучерявая");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лунегова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Маммадов");
            obj.Set("Name", "Фаиг");
            obj.Set("Sername", "Низам");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Медведев");
            obj.Set("Name", "Александр");
            obj.Set("Sername", "Дмитриевич");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Минжасаров");
            obj.Set("Name", "Амир");
            obj.Set("Sername", "Тындамасович");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Нусратуллоев");
            obj.Set("Name", "Рахматулло");
            obj.Set("Sername", "Файзуллоевич");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Оганесян");
            obj.Set("Name", "Михаил");
            obj.Set("Sername", "Борисович");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Парфирова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пименов");
            obj.Set("Name", "Владислав");
            obj.Set("Sername", "Андреевич");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Прикасчиков");
            obj.Set("Name", "Егор");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Россиев");
            obj.Set("Name", "Эдуард");
            obj.Set("Sername", "Алексеевич");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тюсов");
            obj.Set("Name", "Дмитрий");
            obj.Set("Sername", "Игоревич");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шамина");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "1151");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Адгезалов");
            obj.Set("Name", "Элнур");
            obj.Set("Sername", "Ризван");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Антонян");
            obj.Set("Name", "Мэри");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Буланова");
            obj.Set("Name", "Владислава");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Военков");
            obj.Set("Name", "Александр");
            obj.Set("Sername", "Дмитриевич");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Военков");
            obj.Set("Name", "Михаил");
            obj.Set("Sername", "Дмитриевич");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гроцкий");
            obj.Set("Name", "Евгений");
            obj.Set("Sername", "Вячеславович");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Дементьев");
            obj.Set("Name", "Андрей");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зуйкова");
            obj.Set("Name", "Кристина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Изосимова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Каташева");
            obj.Set("Name", "Алиса");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Киселев");
            obj.Set("Name", "Владимир");
            obj.Set("Sername", "Евгеньевич");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Клингенберг");
            obj.Set("Name", "Вадим");
            obj.Set("Sername", "Игоревич");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Князева");
            obj.Set("Name", "Алена");
            obj.Set("Sername", "Максимовна");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кязимов");
            obj.Set("Name", "Ахмед");
            obj.Set("Sername", "Расим");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Линниченко");
            obj.Set("Name", "Павел");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Манонова");
            obj.Set("Name", "Злата");
            obj.Set("Sername", "Салаватовна");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Матвеенко");
            obj.Set("Name", "Александр");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мукумов");
            obj.Set("Name", "Азамат");
            obj.Set("Sername", "Ахматджонович");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Никитина");
            obj.Set("Name", "Евгения");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Оздемиров");
            obj.Set("Name", "Иса");
            obj.Set("Sername", "Махмудович");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Орипов");
            obj.Set("Name", "Иномжон");
            obj.Set("Sername", "Зафарович");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Попонина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Савватеев");
            obj.Set("Name", "Степан");
            obj.Set("Sername", "Романович");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ухов");
            obj.Set("Name", "Игорь");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шайхутдинов");
            obj.Set("Name", "Раиль");
            obj.Set("Sername", "Наилевич");
            obj.Set("Group", "1152");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абрамкина");
            obj.Set("Name", "Ксения");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аверьянова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бахарева");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Белоусова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ветохина");
            obj.Set("Name", "Олеся");
            obj.Set("Sername", "Джамаладдиновна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гаранин");
            obj.Set("Name", "Алексей");
            obj.Set("Sername", "Геннадьевич");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Громилин");
            obj.Set("Name", "Анатолий");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гуларян");
            obj.Set("Name", "Наира");
            obj.Set("Sername", "Джоновна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Изюмова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Казакова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кассаева");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Каськова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кузьмина");
            obj.Set("Name", "Евгения");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кутумова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Максимова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мергалеева");
            obj.Set("Name", "Кристина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Миллер");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Озерова");
            obj.Set("Name", "Алеся");
            obj.Set("Sername", "Карчагаевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Паймулина");
            obj.Set("Name", "Лилия");
            obj.Set("Sername", "Львовна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Савельева");
            obj.Set("Name", "Евгения");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Саяпина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Светкина");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Улитина");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Чабаев");
            obj.Set("Name", "Максим");
            obj.Set("Sername", "Валерьевич");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Яковлева");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2111");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аксенова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аксенова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Брынзина");
            obj.Set("Name", "Алена");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бурмистрова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Валишев");
            obj.Set("Name", "Виль");
            obj.Set("Sername", "Дамирович");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Голубчик");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Григорьева");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Борисовна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гуслянникова");
            obj.Set("Name", "Тамара");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Давоян");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Геворковна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Есин");
            obj.Set("Name", "Александр");
            obj.Set("Sername", "Александрович");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Замиралов");
            obj.Set("Name", "Станислав");
            obj.Set("Sername", "Янисович");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Картавых");
            obj.Set("Name", "Марьяна");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Касаткина");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Корнилова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кравченко");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кузнецова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мироненко");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Эдуардовна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Моисеенко");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Набокова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Новикова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Панжинская");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сиразетдинова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Валентиновна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сырова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Утенкова");
            obj.Set("Name", "Маргарита");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Феклистова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "2112");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Алашева");
            obj.Set("Name", "Айша");
            obj.Set("Sername", "Максотовна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Алтунина");
            obj.Set("Name", "Оксана");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Баканова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Белова");
            obj.Set("Name", "Алиса");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Володина");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Романовна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Голованова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Борисовна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ермакова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Залуженцева");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кайдарова");
            obj.Set("Name", "Диана");
            obj.Set("Sername", "Денисовна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Калиновская");
            obj.Set("Name", "Маргарита");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кузнецова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Курчаева");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Маньшина");
            obj.Set("Name", "Алена");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Матаева");
            obj.Set("Name", "Карина");
            obj.Set("Sername", "Абдул-Хадиевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Матвеева");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Назарова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Погожева");
            obj.Set("Name", "Инна");
            obj.Set("Sername", "Станиславовна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Редникина");
            obj.Set("Name", "Валентина");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Родина");
            obj.Set("Name", "Ангелина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сдобникова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сергеева");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Симдянова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Черухина");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Чинчик");
            obj.Set("Name", "Лилия");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Цибульникова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "2113");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Алтунина");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Васильевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аппанов");
            obj.Set("Name", "Владислав");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Арбузова");
            obj.Set("Name", "Галина");
            obj.Set("Sername", "Владиславовна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Василос");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гейдарова");
            obj.Set("Name", "Телли");
            obj.Set("Sername", "Мехмановна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гнедкова");
            obj.Set("Name", "Маргарита");
            obj.Set("Sername", "Васильевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зароченцева");
            obj.Set("Name", "Маргарита");
            obj.Set("Sername", "Тиграновна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Иванова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Канюкова");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кашапова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кобякова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кожухова");
            obj.Set("Name", "Дарьяна");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Конина");
            obj.Set("Name", "Ирена");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лужаева");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лучко");
            obj.Set("Name", "Диана");
            obj.Set("Sername", "Борисовна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Макарова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Морозова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мухитдинова");
            obj.Set("Name", "Инара");
            obj.Set("Sername", "Мунировна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Никифорчук");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Попова");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Похилова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рузавин");
            obj.Set("Name", "Игорь");
            obj.Set("Sername", "Олегович");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Татьянин");
            obj.Set("Name", "Владимир");
            obj.Set("Sername", "Андреевич");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Терещенко");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Якушкина");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "2114");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Архандеева");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Петровна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Васюхина");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Верещагина");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Воронова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гаевская");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Игнатьева");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карпова");
            obj.Set("Name", "Евгения");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карпова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Константинова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Валериевна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Константинова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Махортов");
            obj.Set("Name", "Сергей");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Меньшова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Салихова");
            obj.Set("Name", "Гульназ");
            obj.Set("Sername", "Рифкатовна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сапожникова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Саушева");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Струкова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Константиновна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тимофеева");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тищенко");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Станиславовна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тищенко");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тошматова");
            obj.Set("Name", "Малика");
            obj.Set("Sername", "Джалолидиновна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Третьякова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Григорьевна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Турыгина");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ярулина");
            obj.Set("Name", "Дина");
            obj.Set("Sername", "Абульмухамедовна");
            obj.Set("Group", "2115");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абдалова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Алексеева");
            obj.Set("Name", "Полина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Амплетова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Батурова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Белоусова");
            obj.Set("Name", "Дарья");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бобко");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гусева");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Девочкина");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зыбанова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зайкова");
            obj.Set("Name", "Наиля");
            obj.Set("Sername", "Фаритовна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кистанова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кожевникова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кузнецова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лутфуллина");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Максимова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Самсонова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сосновская");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Татаренкова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Фадеев");
            obj.Set("Name", "Алексей");
            obj.Set("Sername", "Олегович");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Чернышов");
            obj.Set("Name", "Константин");
            obj.Set("Sername", "Сергеевич");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шереметьева");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шевченко");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "2116");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Апраськин");
            obj.Set("Name", "Евгений");
            obj.Set("Sername", "Валериевич");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Архипова");
            obj.Set("Name", "Надежда");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аюпова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Олеговна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Барсукова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Барсукова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бодягина");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Борисов");
            obj.Set("Name", "Андрей");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Вдовина");
            obj.Set("Name", "Евгения");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гарягдыева");
            obj.Set("Name", "Айлар");
            obj.Set("Sername", "Сердаровна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Глухова");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Дорожкина");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ермакова");
            obj.Set("Name", "Галина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Панова");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Илатовская");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Садыкова");
            obj.Set("Name", "Зарина");
            obj.Set("Sername", "Абульмухамедовна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лисовская");
            obj.Set("Name", "Надежда");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мишина");
            obj.Set("Name", "Карина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Москвитина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Салихов");
            obj.Set("Name", "Равиль");
            obj.Set("Sername", "Исхакович");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Севостьянова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сонина");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Стрельникова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сумина");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Черняев");
            obj.Set("Name", "Сергей");
            obj.Set("Sername", "Павлович");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Яблочкина");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "2117");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Голубева");
            obj.Set("Name", "Яна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Горчицина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зулькарнеева");
            obj.Set("Name", "Фарида");
            obj.Set("Sername", "Нормухаметовна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Исчалов");
            obj.Set("Name", "Александр");
            obj.Set("Sername", "Николаевич");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Казакова");
            obj.Set("Name", "Вера");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кибо");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мальцева");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мальцева");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мишанова");
            obj.Set("Name", "Надежда");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Наськина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пронькина");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пшениснова");
            obj.Set("Name", "Альфия");
            obj.Set("Sername", "Рушановна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Романычева");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рыбакова");
            obj.Set("Name", "Майя");
            obj.Set("Sername", "Валериевна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Самчелейкин");
            obj.Set("Name", "Андрей");
            obj.Set("Sername", "Николаевич");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сафиуллина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Дамировна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Степанова");
            obj.Set("Name", "Оксана");
            obj.Set("Sername", "Федоровна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Теренченко");
            obj.Set("Name", "Анастасия");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шахова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Печенина");
            obj.Set("Name", "Людмила");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Печенина");
            obj.Set("Name", "Людмила");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2118");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Айтиева");
            obj.Set("Name", "Виолетта");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аитова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Девятайкина");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Иванов");
            obj.Set("Name", "Иван");
            obj.Set("Sername", "Евгеньевич");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Клевакина");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Куделькина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Латыпова");
            obj.Set("Name", "Алсу");
            obj.Set("Sername", "Раилевна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Макарова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Макарова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Миханькова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Аркадьевна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Нематова");
            obj.Set("Name", "Руфана");
            obj.Set("Sername", "Эльдар");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Отрощенко");
            obj.Set("Name", "Карина");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Салдеева");
            obj.Set("Name", "Сабрина");
            obj.Set("Sername", "Ильдаровна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Самсонова");
            obj.Set("Name", "Валентина");
            obj.Set("Sername", "Ивановна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Самсонова");
            obj.Set("Name", "Вера");
            obj.Set("Sername", "Ивановна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Смольникова");
            obj.Set("Name", "Валентина");
            obj.Set("Sername", "Петровна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Чигиринская");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Чугарова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "2161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Алабьева");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Баландина");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бычкина");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Денисова");
            obj.Set("Name", "Оксана");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Евстафьева");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лобова");
            obj.Set("Name", "Таисия");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лунева");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Махмадаминов");
            obj.Set("Name", "Рамазон");
            obj.Set("Sername", "Махмадаминович");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Нагиева");
            obj.Set("Name", "Сара");
            obj.Set("Sername", "Рафик");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Саранина");
            obj.Set("Name", "Альбина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сейтхалилова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Синичкина");
            obj.Set("Name", "Эльвира");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тошев");
            obj.Set("Name", "Бахтиер");
            obj.Set("Sername", "Алавидинович");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тюгалева");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Филушкина");
            obj.Set("Name", "Олеся");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Харитонов");
            obj.Set("Name", "Павел");
            obj.Set("Sername", "Владимирович");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Хусейнов");
            obj.Set("Name", "Акмолджон");
            obj.Set("Sername", "Алиевич");
            obj.Set("Group", "2162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ананьева");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Арипова");
            obj.Set("Name", "Ания");
            obj.Set("Sername", "Талгатовна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ахметжанова");
            obj.Set("Name", "Камиля");
            obj.Set("Sername", "Адилхановна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Батыргареева");
            obj.Set("Name", "Ангелина");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Борисова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Валерьевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гайникамалова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Фаритовна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Галимова");
            obj.Set("Name", "Айгуль");
            obj.Set("Sername", "Ильшатовна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Долгова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Вячеславовна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Евдокимова");
            obj.Set("Name", "Регина");
            obj.Set("Sername", "Гафоровна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Курдова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Киркина");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кулемина");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Куприянова");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Курамшина");
            obj.Set("Name", "Флюра");
            obj.Set("Sername", "Рафаильевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Курдюкова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Масакова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Муратшина");
            obj.Set("Name", "Динара");
            obj.Set("Sername", "Ринатовна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Петрова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Родькина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Рысаева");
            obj.Set("Name", "Лилия");
            obj.Set("Sername", "Гумаровна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Самородова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Стрелкова");
            obj.Set("Name", "Евгения");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тасмухамбетова");
            obj.Set("Name", "Нургуль");
            obj.Set("Sername", "Уразбаевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Форофонтова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шегенбаева");
            obj.Set("Name", "Альбина");
            obj.Set("Sername", "Ермуратовна");
            obj.Set("Group", "3161");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абрамова");
            obj.Set("Name", "Жанна");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абсалямова");
            obj.Set("Name", "Гульнара");
            obj.Set("Sername", "Баязитовна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бундина");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бундина");
            obj.Set("Name", "Ангелина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бурлакова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Григоревская");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Григорьева");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Павловна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ивахненко");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Косякова");
            obj.Set("Name", "Любовь");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кравченко");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кузнецова");
            obj.Set("Name", "Екатерина");
            obj.Set("Sername", "Дмитриевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Михайлова");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Михалкина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Прокаева");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Резун");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Санталова");
            obj.Set("Name", "Людмила");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Смирнова");
            obj.Set("Name", "Оксана");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сомова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Уточкина");
            obj.Set("Name", "Варвара");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Федотова");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Хмелева");
            obj.Set("Name", "Валерия");
            obj.Set("Sername", "Витальевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Черменина");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Геннадьевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шакирова");
            obj.Set("Name", "Ольга");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Юркова");
            obj.Set("Name", "Наталия");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Якупова");
            obj.Set("Name", "Рамиля");
            obj.Set("Sername", "Ринатовна");
            obj.Set("Group", "3162");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Абдрахманова");
            obj.Set("Name", "Регина");
            obj.Set("Sername", "Фануровна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Акдавлетова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Акрамовна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Акулинина");
            obj.Set("Name", "Любовь");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Багнюк");
            obj.Set("Name", "Лилия");
            obj.Set("Sername", "Андреевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бахтиярова");
            obj.Set("Name", "Дина");
            obj.Set("Sername", "Сарсенгалиевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бурлуцкая");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Валявина");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Алексеевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Вареникова");
            obj.Set("Name", "Людмила");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гречухина");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гумерова");
            obj.Set("Name", "Гузель");
            obj.Set("Sername", "Салаватовна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Досхалинова");
            obj.Set("Name", "Дана");
            obj.Set("Sername", "Мухтаровна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Жумагазиева");
            obj.Set("Name", "Кунслу");
            obj.Set("Sername", "Сансызбаевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Забаева");
            obj.Set("Name", "Регина");
            obj.Set("Sername", "Алтынбаевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Исхакова");
            obj.Set("Name", "Динара");
            obj.Set("Sername", "Айратовна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Кабаева");
            obj.Set("Name", "Оксана");
            obj.Set("Sername", "Константиновна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Карабалеева");
            obj.Set("Name", "Жания");
            obj.Set("Sername", "Жумабековна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Красильникова");
            obj.Set("Name", "Галина");
            obj.Set("Sername", "Васильевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Лузбаева");
            obj.Set("Name", "Русалина");
            obj.Set("Sername", "Серикпаевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мазитова");
            obj.Set("Name", "Гульмира");
            obj.Set("Sername", "Эсентуровна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мухамбетова");
            obj.Set("Name", "Альбина");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мухтубаева");
            obj.Set("Name", "Лязат");
            obj.Set("Sername", "Макаровна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Назарова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Ринатовна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Наурзалинова");
            obj.Set("Name", "Алина");
            obj.Set("Sername", "Булатовна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Подымова");
            obj.Set("Name", "Лариса");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Попова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "3163");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Алдабергенова");
            obj.Set("Name", "Вероника");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Антонова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Баширова");
            obj.Set("Name", "Элена");
            obj.Set("Sername", "Эдуардовна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бобылева");
            obj.Set("Name", "Любовь");
            obj.Set("Sername", "Васильевна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Бражникова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Вертелецкая");
            obj.Set("Name", "Александра");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Викторова");
            obj.Set("Name", "Оксана");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Волгина");
            obj.Set("Name", "Марина");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Гайнулина");
            obj.Set("Name", "Язгуль");
            obj.Set("Sername", "Вахитовна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Жулмурзинова");
            obj.Set("Name", "Виктория");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Завражнова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Зуева");
            obj.Set("Name", "Анна");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ивлева");
            obj.Set("Name", "Нина");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Игошина");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Имамбаева");
            obj.Set("Name", "Анара");
            obj.Set("Sername", "Бахитовна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Каратеева");
            obj.Set("Name", "Алия");
            obj.Set("Sername", "Бахыткиреевна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Каримова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Маргарян");
            obj.Set("Name", "Ирина");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Маслина");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мироновская");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Михайлина");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Сергеевна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Недашковская");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Ниязгулова");
            obj.Set("Name", "Гулбану");
            obj.Set("Sername", "Онгарбаевна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Нурахметова");
            obj.Set("Name", "Айжан");
            obj.Set("Sername", "Асхатовна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Пархоменко");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3164");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Авдеева");
            obj.Set("Name", "Алла");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Аллахвердиева");
            obj.Set("Name", "Миная");
            obj.Set("Sername", "Али-кзы");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Блажева");
            obj.Set("Name", "Алла");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Блохина");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Егорова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Михайловна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Измайлова");
            obj.Set("Name", "Гелфиня");
            obj.Set("Sername", "Ислямутдиновна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Колюшева");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Константинова");
            obj.Set("Name", "Надежда");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Копытина");
            obj.Set("Name", "Галина");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Коршикова");
            obj.Set("Name", "Мария");
            obj.Set("Sername", "Борисовна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Мухамбетова");
            obj.Set("Name", "Миргуль");
            obj.Set("Sername", "Адельхановна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Нигматуллин");
            obj.Set("Name", "Динар");
            obj.Set("Sername", "Дамирович");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Сабирова");
            obj.Set("Name", "Юлия");
            obj.Set("Sername", "Владимировна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Степанова");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Александровна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Стрельникова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Георгиевна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Титова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Евгеньевна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Тур");
            obj.Set("Name", "Елена");
            obj.Set("Sername", "Николаевна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Усманова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Юрьевна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Хамукова");
            obj.Set("Name", "Наталья");
            obj.Set("Sername", "Ивановна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Хисаметдинова");
            obj.Set("Name", "Валентина");
            obj.Set("Sername", "Анатольевна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Шевараева");
            obj.Set("Name", "Татьяна");
            obj.Set("Sername", "Викторовна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Юдакова");
            obj.Set("Name", "Светлана");
            obj.Set("Sername", "Ивановна");
            obj.Set("Group", "3165");
            this.list.Add(obj);

            obj = new ArrivedStudentObject();
            obj.Set("Family", "Якуц");
            obj.Set("Name", "Оксана");
            obj.Set("Sername", "Игоревна");
            obj.Set("Group", "3165");
            this.list.Add(obj);
        }

        private bool pleaseCommerce2018(String request)
        {
            if (request == "1123") return true;
            if (request == "0181") return true;
            if (request == "0281") return true;
            if (request == "0341") return true;
            if (request == "0381") return true;
            if (request == "0120") return true;
            if (request == "0121") return true;
            if (request == "0216") return true;
            if (request == "0222") return true;
            if (request == "0320") return true;
            if (request == "2115") return true;
            if (request == "2116") return true;
            if (request == "2217") return true;
            if (request == "2218") return true;
            if (request == "2311") return true;
            if (request == "2313") return true;
            if (request == "2317") return true;
            if (request == "1151") return true;
            if (request == "1251") return true;
            if (request == "1252") return true;
            if (request == "0161") return true;
            if (request == "0162") return true;
            if (request == "0261") return true;
            if (request == "0262") return true;
            if (request == "0263") return true;
            if (request == "0361") return true;
            if (request == "0362") return true;
            if (request == "0363") return true;
            if (request == "1261") return true;
            if (request == "1361") return true;
            if (request == "2161") return true;
            if (request == "2261") return true;
            if (request == "2262") return true;
            if (request == "2361") return true;
            if (request == "2362") return true;
            if (request == "3161") return true;
            if (request == "3162") return true;
            if (request == "3163") return true;
            if (request == "3261") return true;
            if (request == "3265") return true;
            return false;

        }



    }
}
