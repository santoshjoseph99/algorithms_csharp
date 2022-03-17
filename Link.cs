using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draw_network
{
    internal class Link
    {
        public Network Network { get; set; }
        public Node FromNode { get; set; }
        public Node ToNode { get; set; }
        public int Cost { get; set; }

        public Link(Network network, Node fromNode, Node toNode, int cost)
        {
            Network = network;
            FromNode = fromNode;
            ToNode = toNode;
            Cost = cost;
        }

        public override string ToString()
        {
            return String.Format("{0} --> {1} ({2})", FromNode, ToNode, Cost);
        }
    }

}
