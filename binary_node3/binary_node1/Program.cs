using System;

namespace binary_node3
{

 
    class Program
    {
        static void FindValue<T>(BinaryNode<T> node, T value)
        {
            var result = node.FindNode(value);
            if(result)
            {
                Console.WriteLine("Found {0}", value);
            }
            else
            {
                Console.WriteLine("Value {0} not found", value);
            }
        }

        static void Main(string[] args)
        {
            var rootNode = new BinaryNode<string>("Root");
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

            // Find some values.
            FindValue(rootNode, "Root");
            FindValue(rootNode, "E");
            FindValue(rootNode, "F");
            FindValue(rootNode, "Q");
            // Find F in the B subtree.
            FindValue(bNode, "F");
        }
    }
}
