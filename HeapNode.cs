using System;
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
		public Node Parent;
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
     /*   public Node(Node Node1, Node Node2)
        {
            Parent = null;
            bitcode = "";
            isleaf = false;
            if (Node1.frequency >= Node2.frequency)
            {
                Right = Node1;
                Left = Node2;
                Right.Parent = Left.Parent = this;
                frequency = Node1.frequency + Node2.frequency;
                Symbol = Node1.Symbol + Node2.Symbol;
            }
            else if (Node1.frequency < Node2.frequency)
            {
                Right = Node2;
                Left = Node1;
                Right.Parent = Left.Parent = this;
                frequency = Node1.frequency + Node2.frequency;
                Symbol = Node1.Symbol + Node2.Symbol;
            }
        }*/
        public List<bool> Traverse(char symbol, List<bool> data)
        {
            // Leaf
            if (Right == null && Left == null)
            {
                if (symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);

                    left = Left.Traverse(symbol, leftPath);
                }

                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.Traverse(symbol, rightPath);
                }

                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
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
