using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Single_List.CLinkedList
{
    class SLinkedList
    {
        CustomNode head;
        public List<string> nextlist;
        CustomNode current;
        string data;
        int nodeCount;

        public void appendNode(string data)
        {
            // if a list is empty make the node call its head
            if (head == null)
            {
                head = new CustomNode(data);
                nodeCount++;
                return;
            }
            current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new CustomNode(data);

        }
        public void prepend(string data)
        {
            if (head == null)
            {
                head = new CustomNode(data);
                nodeCount++;
            }
            else
            {
                CustomNode newHead = new CustomNode(data);
                nodeCount++;
                newHead.Next = head;
                head = newHead;
            }
        }

        

        public void deleteWithData(string deleteData)
        {
            if(head == null)
            {
                MessageBox.Show("Cannot delete a value from an empty list");
                return;
            }
            if (head.data.Equals(data))
            {
                head = head.Next;
            }
            current = head;
            while (current.Next!=null)
            {
                if (current.data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Node with data " + data + " deleted");
                }
                current = current.Next;
            }
            MessageBox.Show("Could not delete data because, data is not presented in list");
        }

        public void applyProfanitFilter(string data)
        {
            if (head == null)
            {
                MessageBox.Show("No list to clean ");
            }

            if (head.data.Contains(data))
            {
                string replaceString = head.data.Replace(data, "*****");
                head.data = replaceString;
                MessageBox.Show(head.data);

            }
            current = head;
            while (current.Next!=null)
            {
                current = current.Next;
                if (current.data.Contains(data))
                {
                    string replaceString = current.data.Replace(data, "*****");
                    current.data = replaceString;
                    MessageBox.Show(current.data);
                }
            }
            MessageBox.Show("No swearwords in here");

        }

        public void insertAfter(string nodeData, string searchData)
        {
            if (head == null)
            {
                MessageBox.Show("No list here nana ");
            }
            if (head.data.Contains(searchData)) {
                CustomNode insertNode = new CustomNode(nodeData);
                insertNode.Next = head.Next;
                head.Next = insertNode;
            }
        }

        public List<string> showNext()
        {
            nextlist = new List<string>();
            current = head;

            nextlist.Add(current.data);

            while (current.Next != null)
            {

                nextlist.Add(current.Next.data);
                current = current.Next;

            }
            return nextlist;

        }
    }
}
