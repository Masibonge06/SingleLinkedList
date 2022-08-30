using System;
using System.Collections.Generic;
using System.Text;

namespace Single_List
{
    class CustomNode
    {
        public CustomNode Next;
        public string data;

        public CustomNode()
        {

        }

        public CustomNode(string data)
        {
            this.data = data;
        }
    }
}
