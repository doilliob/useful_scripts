using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SplitXLSX
{
    public partial class Form1 : Form
    {
        private List<string> files;
        private int max_rows = 0;
        private int header_rows = 0;
        private int columnes = 0;

        public Form1()
        {
            InitializeComponent();
            this.files = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Файлы Excel (.xlsx) |*.xlsx";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                this.files = new List<string>();
                foreach (string filename in openFileDialog1.FileNames)
                    this.files.Add(filename);
                this.textBox1.Text = this.files.Count.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               this.max_rows = int.Parse(textBox2.Text);
               this.header_rows = int.Parse(textBox3.Text);
               this.columnes = int.Parse(textBox4.Text);
            }
            catch(Exception excep)
            {
                MessageBox.Show("Возникла ошибка! Возможно Вы ввели не цифры в цифровом поле! " + excep.ToString(), "Ошибка", MessageBoxButtons.OK);
                return;
            }
            ParseXLSX();
        }

        private void ParseXLSX()
        {

            int all_files_count = this.files.Count;
            int current_file = 0;
            bool without_errors = true;
            foreach (string file in this.files)
            {
                current_file++;
                this.label5.Text = current_file.ToString() + " из " + all_files_count.ToString();

                Excel.Application excelApp = null; 
                Excel.Workbook excelBook = null;
                Excel._Worksheet workSheet = null;

                
                try
                {
                    excelApp = new Excel.Application();
                    excelApp.Visible = false;
                    excelApp.DisplayAlerts = false;
                    excelBook = excelApp.Workbooks.Add(file);
                    workSheet = excelBook.ActiveSheet;
                    string SheetName = workSheet.Name;
                    int all_rows_count = 0;
                    int row = this.header_rows + 1;
                    int col = 1;
                    // Подсчет строк
                    while ((workSheet.Cells[row, col] as Excel.Range).Value != null)
                    { row++; all_rows_count++; }
                    
     
                    if(all_rows_count > this.max_rows)
                    {
                        // Прогрессор
                        this.progressBar1.Maximum = all_rows_count;
                        this.progressBar1.Minimum = 0;
                        this.progressBar1.Value = 0;
                        this.progressBar1.Step = 1;

                        // Текуший документ
                        int start_row = this.header_rows + 1;

                        // Копия
                        int childs = 0;
                        int rows_copy = 0;
                        Excel.Workbook child_book = null;
                        Excel._Worksheet child_sheet = null;

                        // Поехали по всему документу
                        for (int i = 0; i < all_rows_count; i++)
                        {
                            // Если не открыт файл
                            if(child_book == null)
                            {
                                // Открываем дочерний документ
                                child_book = excelApp.Workbooks.Add();
                                child_sheet = child_book.ActiveSheet;
                                child_sheet.Name = SheetName;
                                // Копируем шапку
                                (workSheet.Range[workSheet.Cells[1,1], workSheet.Cells[this.header_rows,this.columnes]] as Excel.Range).Copy();
                                (child_sheet.Range[child_sheet.Cells[1,1], child_sheet.Cells[this.header_rows,this.columnes]])
                                    .PasteSpecial(this.checkBox1.Checked ? Excel.XlPasteType.xlPasteValues : Excel.XlPasteType.xlPasteAll, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
                                /*
                                Excel.Range headerrange = workSheet.Range[workSheet.Cells[1][1], workSheet.Cells[this.header_rows][this.columnes]];
                                //headerrange.Select();
                                headerrange.Copy();
                                Excel.Range headerrange2 = child_sheet.Range[child_sheet.Cells[1][1], child_sheet.Cells[this.header_rows][this.columnes]];
                                //headerrange2.Select();
                                headerrange2.PasteSpecial(Excel.XlPasteType.xlPasteAll, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);*/
                            }
                            // Копируем строку
                            int current_row = start_row + i;
                            int current_child_row = this.header_rows + 1 + rows_copy;
                            (workSheet.Range[workSheet.Cells[current_row,1], workSheet.Cells[current_row,this.columnes]] as Excel.Range).Copy();
                            (child_sheet.Range[child_sheet.Cells[current_child_row,1], child_sheet.Cells[current_child_row,this.columnes]] as Excel.Range)
                                .PasteSpecial(this.checkBox1.Checked ? Excel.XlPasteType.xlPasteValues : Excel.XlPasteType.xlPasteAll, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
                            //Excel.Range range = workSheet.Range[workSheet.Cells[current_row][1], workSheet.Cells[current_row][this.columnes]];
                            //range.Copy();
                            // Вставляем

                            //Excel.Range range2 = child_sheet.Range[child_sheet.Cells[current_child_row][1], child_sheet.Cells[current_child_row][this.columnes]];
                            //range2.PasteSpecial(Excel.XlPasteType.xlPasteAll, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);

                            //range = null;
                            //range2 = null;
                            // Отмечаем
                            rows_copy++;
                            this.progressBar1.PerformStep();


                            // если нужное количество строк скопировано
                            if (rows_copy >= this.max_rows)
                            {
                                child_book.SaveAs(file + "_" + (childs++).ToString() + ".xlsx");
                                child_book.Close();
                                child_book = null;
                                child_sheet = null;
                                rows_copy = 0;
                            }
                            
                        }
                        if(child_book != null)
                        {
                            child_book.SaveAs(file + "_" + (childs++).ToString() + ".xlsx");
                            child_book.Close();
                            child_book = null;
                            child_sheet = null;
                        }
                        this.progressBar1.PerformStep();



                        /*int Books = 0;
                        int CurrentBook = 0;
                        Excel.Workbook childBook = excelApp.Workbooks.Add(file + CurrentBook)*/


                    }
                }
                catch(Exception e)
                {
                    without_errors = false;
                    //MessageBox.Show("Возникла ошибка парсинга документа! " + e.ToString(), "Ошибка", MessageBoxButtons.OK);
                    //return;
                }
                finally
                {
                    if (excelBook != null)
                        excelBook.Close();
                    if (excelApp != null)
                        excelApp = null;
                }

                
            }
            if(without_errors)
                MessageBox.Show("Все документы обработаны успешно!", "Информация", MessageBoxButtons.OK);
            else
                MessageBox.Show("Все документы обработаны. Имеются ошибки!", "Информация", MessageBoxButtons.OK);

        }


        public void JoinXLSX()
        {
            int all_files_count = this.files.Count;
            int current_file = 0;
            bool without_errors = true;
            bool if_first_file = true;

            // Прогрессор
            this.progressBar1.Maximum = this.files.Count;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Value = 0;
            this.progressBar1.Step = 1;

            // Инициализация общего файла
            Excel.Application excelApp = null;
            Excel.Workbook join_excelBook = null;
            Excel._Worksheet join_workSheet = null;
            try
            {
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false;
                join_excelBook = excelApp.Workbooks.Add();
                join_workSheet = join_excelBook.ActiveSheet;
                join_workSheet.Name = "Объединение";
            }
            catch (Exception e)
            {
                throw new Exception("Ошибка создания общего файла!");
                return;
            }

            int current_pos_row = this.header_rows + 1;
            // Для каждого файла
            foreach (string file in this.files)
            {
                current_file++;
                this.label5.Text = current_file.ToString() + " из " + all_files_count.ToString();

                Excel.Workbook process_excelBook = null;
                Excel._Worksheet process_workSheet = null;

                try
                {
                    process_excelBook = excelApp.Workbooks.Add(file);
                    process_workSheet = process_excelBook.ActiveSheet;

                    // Копируем шапку
                    if (if_first_file)
                    {
                        (process_workSheet.Range[process_workSheet.Cells[1, 1], process_workSheet.Cells[this.header_rows, this.columnes]] as Excel.Range).Copy();
                        (join_workSheet.Range[join_workSheet.Cells[1, 1], join_workSheet.Cells[this.header_rows, this.columnes]])
                            .PasteSpecial(this.checkBox1.Checked ? Excel.XlPasteType.xlPasteValues : Excel.XlPasteType.xlPasteAll, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);

                        if_first_file = false;
                    }//-/-


                    int col = 1;
                    
                    // Подсчитываем строки
                    int process_start_row = this.header_rows + 1;
                    int process_end_row = 1;
                    while ((process_workSheet.Cells[process_end_row, col] as Excel.Range).Value != null)
                        process_end_row++;
                    process_end_row--;
                    

                    // Копирование всего содержимого файла
                    (process_workSheet.Range[process_workSheet.Cells[process_start_row, col], process_workSheet.Cells[process_end_row, this.columnes]] as Excel.Range).Copy();
                    (join_workSheet.Range[join_workSheet.Cells[current_pos_row, col], join_workSheet.Cells[current_pos_row + (process_end_row - process_start_row), this.columnes]])
                        .PasteSpecial(this.checkBox1.Checked ? Excel.XlPasteType.xlPasteValues : Excel.XlPasteType.xlPasteAll, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
                    current_pos_row += (process_end_row - process_start_row) + 1;
                    

                    process_workSheet = null;
                    process_excelBook.Close();
                    process_excelBook = null;

                } catch (Exception e)
                {
                    // Закрываем обрабатываемый файл
                    if (process_excelBook != null)
                    {
                        process_workSheet = null;
                        process_excelBook.Close();
                        process_excelBook = null;
                    }
                    without_errors = false;

                }
                // Прогресс
                this.progressBar1.PerformStep();
            }
            if(excelApp != null)
                excelApp.Visible = true;

            if (without_errors)
                MessageBox.Show("Все документы обработаны успешно!", "Информация", MessageBoxButtons.OK);
            else
                MessageBox.Show("Все документы обработаны. Имеются ошибки!", "Информация", MessageBoxButtons.OK);
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.header_rows = int.Parse(textBox3.Text);
                this.columnes = int.Parse(textBox4.Text);
            }
            catch (Exception excep)
            {
                MessageBox.Show("Возникла ошибка! Возможно Вы ввели не цифры в цифровом поле! " + excep.ToString(), "Ошибка", MessageBoxButtons.OK);
                return;
            }
            this.JoinXLSX();
        }


    }
}
