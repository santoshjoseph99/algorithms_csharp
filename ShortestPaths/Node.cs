﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPaths
{
    internal class Node
    {
        public int Index { get; set; }
        public Network Network { get; set; }
        public Point Center { get; set; }
        public List<Link> Links { get; set; }
        public String Text { get; set; }

        public Node(Network network, Point center, String text)
        {
            Network = network;
            Center = center;
            Text = text;
            Index = -1;
            Links = new List<Link>();
            Network.AddNode(this);
        }

        public override string ToString()
        {
            return String.Format("[{0}]", Text);
        }

        public void AddLink(Link link)
        {
            Links.Add(link);
        }
    }
}