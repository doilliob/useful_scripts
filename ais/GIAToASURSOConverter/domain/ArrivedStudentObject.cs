using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GIAToASURSOConverter.domain
{
    class ArrivedStudentObject : ParentObject
    {
        public ArrivedStudentObject() : base()
        {
            this.Add("Family", "", "Фамилия студента", "TEXT");
            this.Add("Name", "", "Имя студента", "TEXT");
            this.Add("Sername", "", "Отчество студента", "TEXT");
            this.Add("Group", "", "Группа", "TEXT");
        }
    }
}
