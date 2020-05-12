using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace birkelime_birislem
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        private WordManager WM;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WM = new WordManager();
        }
        private void btnGenerateWord_Click(object sender, EventArgs e)
        {
            lboxFoundWords.Items.Clear();
            lblSelectedLetters.Text = String.Empty;
            lblSelectedLetters.Text += "Seçilen Harfler: \" ";
            var selectedLetters = WM.GenerateRandomLetter();
            foreach (var item in selectedLetters)
            {
                lblSelectedLetters.Text += (item + " ");
            }

           
            foreach (var item in WM.FindWords())
            {
                lboxFoundWords.Items.Add(item);
            }
            lblSelectedLetters.Text += "\"\n";
            lblSelectedLetters.Text += String.Format("En uzun kelime: \"{0}\"", WM.LongestWord != String.Empty ? WM.LongestWord : "");
            lblSelectedLetters.Text += String.Format("\nJoker harf: {0}", WM.JokerLetter);
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            OperationManager operationManager = new OperationManager();
            Operation operation = operationManager.MakeOperation();
            richTextBox1.Text = operation.OperationSteps;
            lblSelectedNumbers.Text = String.Empty;
            lblSelectedNumbers.Text += "Seçilen Sayılar: ";
            for (int i = 0; i < operationManager.FirstNumbers.Count; i++)
            {
                if (i == operationManager.FirstNumbers.Count - 1)
                {
                    lblSelectedNumbers.Text += operationManager.FirstNumbers[i].ToString();
                    continue;
                }
                lblSelectedNumbers.Text += operationManager.FirstNumbers[i].ToString() + ", ";
            }
         
            lblSelectedNumbers.Text += Environment.NewLine + "Bulunacak Sayı: " + operationManager.NumberToBeFound;
            lblSelectedNumbers.Text += Environment.NewLine + "Bulunan Sayı: " + operation.ResultFound;
        }
    }
}
