using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HUFFMANTEST
{
   

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------FILE COMPRESSION-----------------------------");
            List<Node> Nodes;
            
            
                Tree tree = new Tree();
                
                Console.Write("Enter the path of the file: ");
                String filename = Console.ReadLine();
                //file = filename;
                FileInfo f = new FileInfo(filename);
                long s1 = f.Length;
                Console.Write("FileSize: " + s1.ToString());
                Console.Write("\n");
                Nodes = tree.CalculateFrequency(filename);
                Console.WriteLine("#Symbols   -   #Frequency"); 
                tree.PrintFrequency(Nodes);
                tree.BuildTree(Nodes);
                tree.setHuffcode("", Nodes[0]);
                tree.Ascii("", Nodes[0]);
                tree.Filewrite(Nodes[0]);
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\n#Symbols    -    #Codes\n");
            //tree.Filewrite(nodeList[0]);
                 tree.Printcode(Nodes[0]);
                 Console.WriteLine("\n\n");
                 tree.Hufftree(0, Nodes[0]);
                 tree.compressFile(0, Nodes[0]);
                 tree.extension();
                  Console.Write("\n");
                  tree.Decompress();
           

         

        }
    }
}
