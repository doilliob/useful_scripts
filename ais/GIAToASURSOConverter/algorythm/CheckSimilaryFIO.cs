using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GIAToASURSOConverter.algorythm
{
    class CheckSimilaryFIO
    {
        // Алгоритм проверки ФИО
        public static bool Check(String family, String name, String sername, String family2, String name2, String sername2)
        {
            bool flag = false;
            try
            {
                //1
                family = family.Replace("'", "").Replace(" ", "");
                name = name.Replace("'", "").Replace(" ", "");
                sername = sername.Replace("'", "").Replace(" ", "");
                //2
                family2 = family2.Replace("'", "").Replace(" ", "");
                name2 = name2.Replace("'", "").Replace(" ", "");
                sername2 = sername2.Replace("'", "").Replace(" ", "");
            }
            catch (Exception e)
            {
                return false;
            }

            // Полное совпадение
            if (family2.ToUpper().Contains(family.ToUpper()) &&
                name2.ToUpper().Contains(name.ToUpper()) &&
                sername2.ToUpper().Contains(sername.ToUpper()))
                flag = true;

            // Частичное совпадение
            // По части фамилии и 3 буквам имени-отчества
            try
            {
                if ((family2.Length > 2) &&
                   (family.Length >= family2.Length) &&
                   (name.Length > 3) &&
                   (sername.Length > 3))
                    if (family2.Substring(0, family2.Length - 2).ToUpper().Contains(family.Substring(0, family2.Length - 2).ToUpper()) &&
                        name2.Substring(0, 3).ToUpper().Contains(name.Substring(0, 3).ToUpper()) &&
                        sername2.Substring(0, 3).ToUpper().Contains(sername.Substring(0, 3).ToUpper()))
                        flag = true;
            }
            catch (Exception e) { }

            // По части фамилии и 1 буквам имени-отчества
            try
            {
                if (family2.ToUpper().Contains(family.ToUpper()) &&
                    name2.Substring(0, 1).ToUpper().Contains(name.Substring(0, 1).ToUpper()) &&
                    sername2.Substring(0, 1).ToUpper().Contains(sername.Substring(0, 1).ToUpper()))
                    flag = true;
            }
            catch (Exception e) { }

            return flag;
        }
    }
}
