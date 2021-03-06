using System;

namespace nary_node3
{
    class Program
    {
        static void FindValue<T>(NaryNode<T> node, T value)
        {
            var result = node.FindNode(value);
            if (result)
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
            var rootNode = new NaryNode<String>("Root");
            var aNode = new NaryNode<String>("A");
            var bNode = new NaryNode<String>("B");
            var cNode = new NaryNode<String>("C");
            var dNode = new NaryNode<String>("D");
            var eNode = new NaryNode<String>("E");
            var fNode = new NaryNode<String>("F");
            var gNode = new NaryNode<String>("G");
            var hNode = new NaryNode<String>("H");
            var iNode = new NaryNode<String>("I");

            rootNode.AddChild(aNode);
            rootNode.AddChild(bNode);
            rootNode.AddChild(cNode);
            aNode.AddChild(dNode);
            aNode.AddChild(eNode);
            dNode.AddChild(gNode);
            cNode.AddChild(fNode);
            fNode.AddChild(hNode);
            fNode.AddChild(iNode);

            // Find some values.
            FindValue(rootNode, "Root");
            FindValue(rootNode, "E");
            FindValue(rootNode, "F");
            FindValue(rootNode, "Q");
            // Find F in the C subtree.
            FindValue(cNode, "F");
        }
    }
}

