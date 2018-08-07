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
    public partial class Form1 : Form
    {
        private List<Uczestnik> lista;
        private Form2 edit;
        private Action action;

        public Form1()
        {
            InitializeComponent();
            action = new Action(updateListView);
        }

        private void Form1_Load(object sender, EventArgs ev)
        {
            lista = new List<Uczestnik>();
            lista.Add(new Uczestnik("Mariusz", "Gwiazdecki", "Siedlce", 12));
            lista.Add(new Uczestnik("Grzegorz", "Michalski", "Warszawa", 50));
            updateListView();
        }
        
        private void updateListView()
        {
            ListViewItem lv;
            this.listView1.Items.Clear();
            foreach(Uczestnik u in lista)
                {
                lv = new ListViewItem(u.getImie());
                lv.SubItems.Add(u.getNazwisko());
                lv.SubItems.Add(u.getMiasto());
                lv.SubItems.Add(u.getLiczbaJU().ToString("0.00", System.Globalization.CultureInfo.CurrentCulture));
                this.listView1.Items.Add(lv);
            }
        }

        private void recEdit()
        {
            int ind = listView1.SelectedIndices[0];
            edit = new Form2(lista, ind, action);
            edit.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            recEdit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            recEdit();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0) return;
            recEdit();
        }
    }
}
