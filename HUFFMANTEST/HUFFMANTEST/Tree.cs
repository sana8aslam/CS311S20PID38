using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace HUFFMANTEST
{
        
    class Tree
    {
                //public string HuffCode;

        public List<Node> CalculateFrequency(string filename)
        {
            List<Node> nodeList = new List<Node>();
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            for (int i = 0; i < stream.Length; i++)
            {
                string read = Convert.ToChar(stream.ReadByte()).ToString();
                if (nodeList.Exists(x => x.Symbol == read))
                    nodeList[nodeList.FindIndex(y => y.Symbol == read)].FrequencyIncrement();
                else
                    nodeList.Add(new Node(read));
            }
            nodeList.Sort();
            return nodeList;
        }

        public void PrintFrequency(List<Node> n)
        {
            foreach (var item in n)
                Console.WriteLine("Symbol : {0} - Frequency : {1}", item.Symbol, item.frequency);
        }
        public void Ascii(string asci, Node node)
        {
            string s = node.Symbol;
            if (node == null)
                return;
            if (node.Left == null && node.Right == null)
            {
                foreach (char c in s.ToCharArray())
                {
                    asci = Convert.ToString(c, 2).PadLeft(8, '0');
                    node.ascii = asci;
                    return;
                }
            }
            Ascii(asci, node.Left);
            Ascii(asci, node.Right);
        }
        public void BuildTree(List<Node> nodes)
        {

            while (nodes.Count > 1)
            {
                List<Node> orderedNodes = nodes.OrderBy(node => node.frequency).ToList<Node>();

                if (orderedNodes.Count >= 2)
                {
                    // Take first two items
                    List<Node> taken = orderedNodes.Take(2).ToList<Node>();

                    // Create a parent node by combining the frequencies

                    // Node n1 = taken[0];
                    //Node n2 = taken[1];
                    Node parent = new Node()
                    {
                        Symbol = taken[0].Symbol + taken[1].Symbol,
                        frequency = taken[0].frequency + taken[1].frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };
                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(parent);
                    //nodes.Add(new Node(n1, n2));
                }
                nodes.Sort();
            }
        }
        public void setHuffcode(string code, Node node)
        {
            if (node == null)
                return;
            if (node.Left == null && node.Right == null)
            {
                node.bitcode = code;
                return;
            }
            setHuffcode(code + "0", node.Left);
            setHuffcode(code + "1", node.Right);
        }
        public void Printcode(Node node)
        {
            if (node == null)
                return;
            if (node.Left == null && node.Right == null)
            {
                
                Console.WriteLine("Symbol : {0} -  Code : {1}", node.Symbol, node.bitcode);
                return;
            }
            Printcode(node.Left);
            Printcode(node.Right);
        }
        public void writer(Node node, StreamWriter path)
        {
            if (node == null)
                return;
            if (node.Left == null && node.Right == null)
            {

                path.WriteLine("Symbol : {0} - Bytes : {1} - Code : {2}", node.Symbol, node.ascii, node.bitcode);
                return;
            }

            writer(node.Left, path);
            writer(node.Right, path);

        }
        public void Filewrite(Node node)
        {
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\fahad\source\repos\HUFFMANTEST\HUFFMANTEST\schemeFile.txt");
            writer(node, streamWriter);
            streamWriter.Close();
            //extension();
        }


        public void Hufftree(int height, Node n)
        {
            

            if (n == null)
                return;
            for (int i = 0; i < height; i++)
            {
                Console.Write("\t");


            }
            Console.Write(n.Symbol);
            Console.Write("\n");
            Hufftree(height + 1, n.Right);
            Hufftree(height + 1, n.Left);
            
                
        }
        public void huffwriter(int height, Node node, StreamWriter path)
        {
            if (node == null)
                return;
            for (int i = 0; i < height; i++)
            {
                Console.Write("\t");


            }

              path.WriteLine( node.Symbol);
              huffwriter(height + 1, node.Left, path);
              huffwriter(height + 1, node.Right, path);

        }
        public void compressFile(int height, Node node)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\fahad\source\repos\HUFFMANTEST\HUFFMANTEST\compress.txt");
            huffwriter(height, node, sw);
            sw.Close();
            //extension();
        }

        public void extension()
        {
            string file = @"C:\Users\fahad\source\repos\HUFFMANTEST\HUFFMANTEST\compress.txt";
            FileInfo filename = new FileInfo(file);
            filename.MoveTo(Path.ChangeExtension(file, ".cmp"));
        }
   
        public bool Isleaf(Node node)
        {
            return (node.Left == null && node.Right == null);
        }
    }
}
