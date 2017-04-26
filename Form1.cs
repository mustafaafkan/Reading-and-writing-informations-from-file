using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace astproject
{

    public partial class Form1 : Form
    {
        SaveFileDialog savefileStrip = new SaveFileDialog();
        OpenFileDialog openfileStrip = new OpenFileDialog();
        public ArrayList nameList = new ArrayList();
        TelephoneBook a = new TelephoneBook();
        ArrayList addContents = new ArrayList();
        public string name, tbox;
        
       public int i = 0;
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openfileStrip.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("The file is chosen");
                nameBox.Clear();
                tnumberBox.Clear();
                listBox1.Items.Clear();
                /*foreach(string contentsOfFile in a.ReadFile(openfileStrip.FileName))
                    listBox1.Items.Add(contentsOfFile);*/
            }
                
        }
        private void saveToolStrip_Click(object sender, EventArgs e)
        {
            if(savefileStrip.ShowDialog()==DialogResult.OK)
            {
                TelephoneBook a = new TelephoneBook();
                a.getNameAndTel(addContents);
                a.WriteToFile(savefileStrip.FileName, addContents);
            }
        }

        private void saveAsToolStrip_Click(object sender, EventArgs e)
        {
            if(savefileStrip.ShowDialog()==DialogResult.OK)
            {
                a.getNameAndTel(addContents);
                a.WriteToFile(savefileStrip.FileName, addContents);
            }
        }

        private void addToolStrip_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            if (addContents.Contains(nameBox.Text + "," + tnumberBox.Text))
                MessageBox.Show("you entered something again");
            else
            {
                addContents.Add(nameBox.Text + "," + tnumberBox.Text);
                nameList.Add(nameBox.Text);
                a[i] = (tnumberBox.Text).ToString();
            }
            nameList.TrimToSize();
                





            nameBox.Clear();
            tnumberBox.Clear();
            i++;
        }
       
           
        private void editToolStrip_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            tbox = tnumberBox.Text;



            if ((listBox1.Text == "") && (name == "") && (tbox == ""))
            {
                foreach (string writer in addContents)
                    listBox1.Items.Add(writer);
            }
            else if ((name == "") || (tbox == ""))
                MessageBox.Show("you must fill all the parts");
            else
            {
                object chosen = listBox1.SelectedItem;
                int contents = addContents.IndexOf(chosen);
                addContents.RemoveAt(contents);
                addContents.Insert(contents, name + "," + tbox);
                nameList.RemoveAt(contents);
                nameList.Insert(contents, name);
                a[contents] = null;
                a[contents] = tbox;
                listBox1.Items.Clear();
                foreach (string writer in addContents)
                    listBox1.Items.Add(writer);
            }
            nameBox.Clear();
            tnumberBox.Clear();


            

            
          
        }

        private void seachNameToolStrip_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            
            if (nameList.Contains(name))
                MessageBox.Show("index is "+nameList.IndexOf(name));

            nameBox.Clear();
            tnumberBox.Clear();
            
        }

        private void searchNumToolStrip_Click(object sender, EventArgs e)
        {
            tbox = tnumberBox.Text;

            for(int counter=0;counter<nameList.Count;counter++)
            {
                if(tbox==a[counter])
                {
                    MessageBox.Show("the index is" + counter);
                }
            }
        }
    }
}
