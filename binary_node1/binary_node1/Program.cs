using System;

namespace binary_node1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new BinaryNode<string>("ROOT");
            var fNode = new BinaryNode<string>("F");
            var eNode = new BinaryNode<string>("E");
            eNode.AddLeft(fNode);
            var bNode = new BinaryNode<string>("B");
            bNode.AddRight(eNode);
            rootNode.AddRight(bNode);
            var cNode = new BinaryNode<string>("C");
            var dNode = new BinaryNode<string>("D");
            var aNode = new BinaryNode<string>("A");
            aNode.AddRight(dNode);
            aNode.AddLeft(cNode);
            rootNode.AddLeft(aNode);

            Console.WriteLine(rootNode);
            Console.WriteLine(aNode);
            Console.WriteLine(bNode);
            Console.WriteLine(cNode);
            Console.WriteLine(dNode);
            Console.WriteLine(eNode);
            Console.WriteLine(fNode);

        }
    }
}
