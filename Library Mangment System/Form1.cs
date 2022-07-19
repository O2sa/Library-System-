using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Mangment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int bookLoan;
        private void LibraryBookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.libraryBookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);


        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.LibraryBook' table. You can move, or remove it, as needed.
            this.libraryBookTableAdapter.Fill(this.libraryDataSet.LibraryBook);
            timer1.Interval = 1000;
            timer1.Start();
            currentDateTextBox.Text = DateTime.Now.ToString("d");
            comboBox1.Items.Add("BookID");
            comboBox1.Items.Add("BookTitle");
            comboBox1.Items.Add("Author");
            


        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime DateDueBack=new DateTime();
            short DaysOverDue;
            double FineRate=1;
            double Fine;
            DateDueBack =DateTime.Parse(dateDueBackTextBox.Text);
            DateTime DateReturned = DateTime.Parse(dateReturnedTextBox.Text);
            DaysOverDue = (short)(DateReturned - DateDueBack).TotalDays;

            switch(numericUpDown1.Value)
            {
                case 0:
                    bookLoan = 1;
                    FineRate = 0.5;
                    break;
                case 1:
                    bookLoan = 3;
                    FineRate = 0.25;

                    break;
                case 2:
                    bookLoan = 5;
                    FineRate = 0.1;

                    break;
                case 3:
                    bookLoan = 7;
                    FineRate = 0.05;

                    break;
                case 4:
                    bookLoan = 10;
                    FineRate = 0.95;

                    break;
                case 5:
                    bookLoan = 15;
                    FineRate = 0.7;

                    break;
                case 6:
                    bookLoan = 20;
                    FineRate = 0.37;

                    break;
                case 7:
                    bookLoan = 30;
                    FineRate = 0.15;

                    break;
                
            }

            if(DaysOverDue<=0)
            {
                DaysOverDue = 0;
            }
            if(DaysOverDue>0)
            {
                Fine = FineRate * DaysOverDue;
            }
            else
            {
                Fine = 0;
            }
            dateOverDue.Text = DaysOverDue + "days overdue";
            lateReturnFineTextBox.Text = "Fine of" + Fine + "$" + "to pay";
            
        }



        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            //time
            string time = "";
            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            //update
             label6.Text = time;            

        }

        private void Borrowed_Click(object sender, EventArgs e)
        {
            dateBorrowedTextBox.Text= DateTime.Now.ToString("d");
            decimal select = numericUpDown1.Value;
            switch (select)
            {
                case 0:
                    bookLoan = 1;
                    break;
                case 1:
                    bookLoan = 3;
                    break;
                case 2:
                    bookLoan = 5;
                    break;
                case 3:
                    bookLoan = 7;
                    break;
                case 4:
                    bookLoan = 10;
                    break;
                case 5:
                    bookLoan = 15;
                    break;
                case 6:
                    bookLoan = 20;
                    break;
                case 7:
                    bookLoan = 25;
                    break;
                
             


            }
            dateDueBackTextBox.Text = DateTime.Now.AddDays(bookLoan).ToString("dddd dd MMM yyyy");
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "BookID":
                    this.libraryBookBindingSource.Filter = "BookID = '" + btnsearch.Text + "'";
                    break;
                case "BookTitle":
                    this.libraryBookBindingSource.Filter = "BookTitle = '" + btnsearch.Text + "'";
                    break;
                case "Author":
                    this.libraryBookBindingSource.Filter = "Author = '" + btnsearch.Text + "'";
                    break;
            }
        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
        }

        private void Btnsearch_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST) m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
