using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUFFMANTEST
{
    
	class Node : IComparable<Node>
	{

        public string Symbol;
		public int frequency;
		public Node Left;
		public Node Right;
		//public Node Parent;
		public string bitcode;
		public string ascii;
		public bool isleaf;

        public Node()
        {

        }
        public Node(string input)
        {
            Left = null;
            Right = null;
           // Parent = null;
            Symbol = input;
            frequency = 1;
            bitcode = "";
            isleaf = true;
        }
       
      

        public int CompareTo( Node node)
		{

			return this.frequency.CompareTo(node.frequency);
		}

		public void FrequencyIncrement()
		{
			frequency++;
		}
	}

}
