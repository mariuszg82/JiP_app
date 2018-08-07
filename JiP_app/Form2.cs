using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiP_app
{
    public partial class Form2 : Form
    {
        private Task tsk;
        private Uczestnik uc;
        private List<Uczestnik> ls;
        private int ind;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Uczestnik> ls, int ind, Action action)
        {
            InitializeComponent();
            this.ls = ls;
            this.ind = ind;
            this.uc = ls[ind];
            this.tsk = new Task(action);
            showRecord();
        }

        private void showRecord()
        {
            textBox1.Text = this.uc.getImie();
            textBox2.Text = this.uc.getNazwisko();
            textBox3.Text = this.uc.getMiasto();
            numericUpDown1.Value = this.uc.getLiczbaJU();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ls[ind] = new Uczestnik(textBox1.Text, textBox2.Text, textBox3.Text, numericUpDown1.Value);
            tsk.RunSynchronously();
            this.Close();
        }
    }
}
