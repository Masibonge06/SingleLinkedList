using MahApps.Metro.Controls.Dialogs;
using Single_List.CLinkedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Single_List
{
    
    public partial class Form1 : Form
    {
        SLinkedList sLinkedList = new SLinkedList();
        List<String> nodesList = new List<String>();
        public Form1()
        {
            InitializeComponent();
            SLinkedList sLinkedList = new SLinkedList();
            sLinkedList.appendNode("I am the Head");
            sLinkedList.appendNode("I am the second Head");
            sLinkedList.appendNode("I am the third Head");

            sLinkedList.prepend("I am the head");
            sLinkedList.prepend("Mwhahaha I am the head");
            sLinkedList.prepend("Look at me, I am the Captain now");

            //sLinkedList.deleteWithData("Look at me, I am the Captain");

            //sLinkedList.applyProfanitFilter("Captain");
            sLinkedList.insertAfter("I have been inserted After", "Look at me, I am the Captain now");

            nodesList = sLinkedList.showNext();

            foreach (string item in nodesList)
            {
                MessageBox.Show(item);
            }
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //MessageDialog message = new MessageDialog()
        }
    }
}
