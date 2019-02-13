using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIAToASURSOConverter.files
{
    class ExcelFilesChooser
    {
        //===================================
        // Выбирает файлы Excel для открытия
        //===================================
        public static String[] Choose()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Файлы Excel (.xlsx) |*.xlsx| Файлы Excel 97-2003 (.xls) |*.xls";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;

            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            if (userClickedOK == DialogResult.OK)
                return openFileDialog1.FileNames;
            else
                return null;
        }
    }
}
