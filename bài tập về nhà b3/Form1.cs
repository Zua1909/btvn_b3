using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_tập_về_nhà_b3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //Tao 1 dong du lieu
            ListViewItem lvi = new ListViewItem(txtFirstName.Text);
            //add cac cot con lai vao lvi
            lvi.SubItems.Add(txtLastname.Text);
            lvi.SubItems.Add(txtPhone.Text);
            //dua du lieu len listview
            listView1.Items.Add(lvi);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.Text = txtFirstName.Text;
                    item.SubItems[1].Text = txtLastname.Text;
                    item.SubItems[2].Text = txtPhone.Text;
                }

                txtFirstName.Clear();
                txtLastname.Clear();
                txtPhone.Clear();
            }
            else
            {
                MessageBox.Show("Hay don dong can sua");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui 1  lòng chọn một hàng để xóa!");
            }
        }
    }
    }
