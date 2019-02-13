using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GIAToASURSOConverter.office
{
    public class ExcelDocumentManager
    {
        // Visible
        private bool visible;
        // Application
        private Excel.Application excelApp;
        // Books
        private List<Excel.Workbook> excelBooks;
        private Excel.Workbook currentBook;
        // Sheets
        private List<Excel.Worksheet> excelSheets;
        private Excel.Worksheet currentSheet;
        // Row/Col
        private int row;
        private int col;

        public ExcelDocumentManager()
        {
            this.visible = false;
            this.row = 1;
            this.col = 1;
            this.excelApp = null;
            this.currentBook = null;
            this.currentSheet = null;
            this.excelBooks = new List<Excel.Workbook>();
            this.excelSheets = new List<Excel.Worksheet>();
        }

        public void setVisible(bool flag) { this.visible = flag;  }

        public Excel.Application getApplication() { return excelApp; }
        public Excel.Workbook getCurrentBook() { return this.currentBook; }
        public Excel.Worksheet getCurrentSheets() { return this.currentSheet; }
        public List<Excel.Workbook> getBooks() { return this.excelBooks; }
        public List<Excel.Worksheet> getSheets() { return this.excelSheets; }
        public int getCurrentRow() { return this.row; }
        public int getCurrentColumn() { return this.col; }

        public void toNextRow() { this.row++; }
        public void toFirstRow() { this.row = 1; }
        public void toFirstColumn() { this.col = 1; }

        // Проверка на пустую ячейку
        public bool empty(int cl)
        {
            return (this.cell(cl).Value == null);
        }

        public bool empty(int r, int cl)
        {
            return (this.cell(r, cl).Value == null);
        }
        
        // Доступ к ячейкам
        public Excel.Range cell(int r, int c)
        {
            return (this.currentSheet.Cells[r, c] as Excel.Range);
        }

        public Excel.Range cell(int cl) 
        {
            this.col = cl;
            return (this.currentSheet.Cells[this.row, cl] as Excel.Range);
        }

      


        /**
         * ==============================================================
         * missing
         * ==============================================================
         */
        private object missing = System.Reflection.Missing.Value;

       

        //===================================
        // Создать документ Excel
        //===================================
        public void CreateExcelApplication()
        {
            try
            {
                this.excelApp = new Excel.Application();
                this.excelApp.Visible = this.visible;
                this.excelApp.DisplayAlerts = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CreateExcelApplication: " + ex.Message);
            }
        }

        //===================================
        // Создать книгу Excel
        //===================================
        public Excel.Workbook CreateWorkbook()
        {
            try
            {
                Excel.Workbook excelBook = this.excelApp.Workbooks.Add();
                this.excelBooks.Add(excelBook);
                this.currentBook = excelBook;
                this.excelSheets.Clear();
                this.currentSheet = null;
                return excelBook;

            }
            catch (Exception ex)
            {
                MessageBox.Show("CreateWorkbook: " + ex.Message);
                return null;
            }
        }

        //===================================
        // Открыть книгу Excel
        //===================================
        public Excel.Workbook OpenWorkbook(String filename)
        {
            try
            {
                Excel.Workbook excelBook = this.excelApp.Workbooks.Add(filename);
                this.excelBooks.Add(excelBook);
                this.currentBook = excelBook;
                // Восстанавливаем листы
                this.excelSheets.Clear();
                foreach (Excel.Worksheet sh in this.currentBook.Sheets)
                    this.excelSheets.Add(sh);
                this.currentSheet = (this.excelSheets.Count == 0) ? null : this.excelSheets[0];
                //
                return excelBook;
            }
            catch (Exception ex)
            {
                MessageBox.Show("OpenWorkbook: " + ex.Message);
                return null;
            }
        }

        //===================================
        // Создать лист Excel
        //===================================
        public Excel.Worksheet OpenSheet()
        {
            try
            {
                Excel.Worksheet excelSheet = this.currentBook.Sheets.Add();
                this.currentSheet = excelSheet;
                return excelSheet;

            }
            catch (Exception ex)
            {
                MessageBox.Show("OpenWorkSheet: " + ex.Message);
                return null;
            }
        }

        //====================================
        // Закрыть лист
        //====================================
        public void CloseSheet()
        {
            if(this.currentSheet != null)
            {
                
            }
        }

        public void CloseBook()
        {
            /*if(this.getCurrentBook != null)
            {
                this.excelBooks.Remove(this.currentBook);
                this.excelSheets.Clear();
                this.currentSheet = null;
                this.currentBook.Close();

            }*/
        }

        public void CloseApplication()
        {
            foreach (Excel.Workbook book in this.excelBooks)
                book.Close();
            this.currentBook = null;
            this.currentSheet = null;
            this.excelBooks.Clear();
            this.excelSheets.Clear();
            this.excelApp.Quit();
        }

    }
}
