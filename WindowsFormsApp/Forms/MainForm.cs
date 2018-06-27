using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.DAL;

namespace WindowsFormsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly Service service; 
        public MainForm()
        {
            service = new Service();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            myTextBox.Text = "Bingo";           
        }

        private void button_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = service.GetAllProviders();
        }
    }
}
