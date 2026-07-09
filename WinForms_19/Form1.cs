using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_19
{
    public partial class Form : System.Windows.Forms.Form

       


    {
        List<string> nameList = new List<string>();
        public Form()
        {
            InitializeComponent();
            lbxName.DataSource = nameList; 
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text; 
                
                if(!string.IsNullOrEmpty(name))
                {

                nameList.Add(name);

                //Refresh 
                lbxName.DataSource = null;
                lbxName.DataSource = nameList; 

                }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nameList.Clear();

            //Refresh 
            lbxName.DataSource = null;
            lbxName.DataSource = nameList;

            //lbxName.Items.Clear();

        }

        private void btnShowSelection_Click(object sender, EventArgs e)
        {
            int index = lbxName.SelectedIndex;

            if(index != -1)
            {
              //  lblShowSelection.Text = "Items index is: " + index;
               // lblOutput.Text = lbxName.SelectedItem.ToString();

                MessageBox.Show("You selected a name: " + nameList[index] + " which is at index: " + index);
            }
          
        }

        private void lbxName_SelectedIndexChanged(object sender, EventArgs e)
        { 
            int index = lbxName.SelectedIndex;

            if(index != -1)
            {
                lblShowSelection.Text = "Items index is: " + index;
                lblOutput.Text = lbxName.SelectedItem.ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbxName.SelectedIndex;

            if(index != -1)
            {
                // lbxName.Items.RemoveAt(index);
                nameList.RemoveAt(index);
                //  Refresh 
                lbxName.DataSource = null;
                lbxName.DataSource = nameList;
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Was hat sich auch geandert
            // Was hat sich auch geandert
            // Was hat sich auch geandert
            // Was hat sich auch geandert
            // Was hat sich auch geandert
            // Was hat sich auch geandert
        }
    }
}
