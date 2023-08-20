using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incomeApp
{
    public partial class Form1 : Form
    {
        DataTable spentNotes = new DataTable();
        public bool editing = false;
        public double salary;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            spentNotes.Columns.Add("Date");
            spentNotes.Columns.Add("Title");
            spentNotes.Columns.Add("Amount Spent");

            spendingNote.DataSource = spentNotes;
            DataGridViewColumn column = spendingNote.Columns[0];
            column.Width = 60;
            DataGridViewColumn row = spendingNote.Columns[0];
            column.Width = 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Converting string to Integer
            double income = Int32.Parse(incomeText.Text);
            double tax = Int32.Parse(taxText.Text);

            //finding out salary after tax deduction
            salary = income - tax;
            incomeLabel.Text = "$" + string.Format("{0:n}", salary);

        }

        private void trackBTN_Click(object sender, EventArgs e)
        {
            //Calculating the new income
            int spent = Int32.Parse(spentText.Text);
            salary = salary - spent;
            incomeLabel.Text = "$" + string.Format("{0:n}", salary);

            if(salary < 0)
            {
                incomeLabel.ForeColor = Color.Red;
            }

            //Storing Data in table
            if(editing)
            {
                spentNotes.Rows[spendingNote.CurrentCell.RowIndex]["Date"] = dateText.Text;
                spentNotes.Rows[spendingNote.CurrentCell.RowIndex]["Title"] = titleText.Text;
                spentNotes.Rows[spendingNote.CurrentCell.RowIndex]["Amount Spent"] = spentText.Text;
            }
            else
            {
                spentNotes.Rows.Add(dateText.Text, titleText.Text, spentText.Text);
            }

            spendingNote.Rows[0].Selected = false;

            dateText.Text = "";
            titleText.Text = "";
            spentText.Text = "";
            editing = false;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            double addMoney = Int32.Parse(addText.Text);
            salary = salary + addMoney;

            incomeLabel.Text = "$" + string.Format("{0:n}", salary);
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                spentNotes.Rows[spendingNote.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Not a valid Note");
            }
        }
    }
}
