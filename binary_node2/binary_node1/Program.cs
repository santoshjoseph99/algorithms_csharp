using System;

namespace binary_node2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new BinaryNode<string>("ROOT");
            var fNode = new BinaryNode<string>("F");
            var eNode = new BinaryNode<string>("E");
            var bNode = new BinaryNode<string>("B");
            var cNode = new BinaryNode<string>("C");
            var dNode = new BinaryNode<string>("D");
            var aNode = new BinaryNode<string>("A");

            eNode.AddLeft(fNode);
        
            bNode.AddRight(eNode);
            rootNode.AddRight(bNode);
           
            aNode.AddRight(dNode);
            aNode.AddLeft(cNode);
            rootNode.AddLeft(aNode);

            Console.WriteLine(rootNode);
        }
    }
}
/*
 ROOT:
   A:
    C:
    D:
   B:
    None
    E:
      F:
      None
 */