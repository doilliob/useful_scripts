using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIAToASURSOConverter.files
{
    class ExcelFileChooser
    {
        //===================================
        // Выбирает файл Excel для открытия
        //===================================
        public static String Choose()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Файлы Excel (.xlsx) |*.xlsx| Файлы Excel 97-2003 (.xls) |*.xls";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            if (userClickedOK == DialogResult.OK)
                return openFileDialog1.FileName;
            else
                return null;
        }

        
    }
}
