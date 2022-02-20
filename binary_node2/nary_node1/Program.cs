using System;

namespace nary_node2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new NaryNode<String>("ROOT");
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

            Console.WriteLine(rootNode);
        }
    }
}
/*
 root
   a:
   b:
 */
