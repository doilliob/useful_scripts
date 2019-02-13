using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Класс ParentObject
 * 
 * Наследуемый класс. Содержит базовые операции
 * для объектов. Все наименования хранит в строках.
 * имеет три поля - field, value, description.
 * Нумерация начинается с 1 (Легче выгружать в Excel)
 **/

namespace GIAToASURSOConverter.domain
{
    class ParentObject
    {
        private List<String> fields;
        private List<String> values;
        private List<String> descriptions;
        private List<String> types;
        private String[] alltypes = ParentObjectFieldTypes.ALL;

        public ParentObject()
        {
            this.fields = new List<string>();
            this.values = new List<string>();
            this.descriptions = new List<string>();
            this.types = new List<string>();
        }

        public void Add(String field, String value, String description, String type)
        {
            if (!this.alltypes.Contains(type))
                throw new Exception("Ошибка добавления неправильного типа");
            this.fields.Add(field);
            this.values.Add(value);
            this.descriptions.Add(description);
            this.types.Add(type);
        }

        public int Length()
        {
            return this.fields.Count;
        }

        /**
         * Type
         **/
        public String Type(String field)
        {
            for (int i = 0; i < this.fields.Count; i++)
                if (field == this.fields[i])
                    return this.types[i];
            return null;
        }

        public String Type(int num)
        {
            if ((num > this.fields.Count) || (num <= 0)) return null;
            else return this.types[num - 1];
        }

        /**
         * VAL
         **/
        public String Value(String field)
        {
            for (int i = 0; i < this.fields.Count; i++)
                if (field == this.fields[i])
                    return this.values[i];
            return null;
        }

        public String Value(int num)
        {
            if ((num > this.fields.Count) || (num <= 0)) return null;
            else return this.values[num - 1];
        }

        public String[] Values()
        {
            return (String[])this.values.ToArray();
        }

        /**
         * FIELD
         **/
        public String Field(int num)
        {
            if ((num > this.fields.Count) || (num <= 0)) return null;
            else return this.fields[num - 1];
        }

        public String[] Fields()
        {
            return (String[])this.fields.ToArray();
        }

        /**
         * DESCRIPTION
         **/
        public String Description(int num)
        {
            if ((num > this.fields.Count) || (num <= 0)) return null;
            else return this.descriptions[num - 1];
        }

        public String[] Descriptions()
        {
            return (String[])this.descriptions.ToArray();
        }

        /**
         * GET SET
         **/
        public void Set(String field, String value)
        {
            for (int i = 0; i < this.fields.Count; i++)
                if (field == this.fields[i])
                    this.values[i] = value;
        }

        public void Set(int num, String value)
        {
            if ((num > this.fields.Count) || (num <= 0))
                throw new Exception("Ошибка обращения по индексу, превышающему размер элементов!");

            num--;
            this.values[num] = value;
        }

        public String Get(String field)
        {
            return this.Value(field);
        }

        public String Get(int num)
        {
            return this.Value(num);
        }

    }
}
