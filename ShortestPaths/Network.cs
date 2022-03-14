using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPaths
{
    internal class Network
    {
        public List<Node> Nodes { get; set; }

        public List<Link> Links { get; set; }

        public Network()
        {
            Clear();
        }

        public void Clear()
        {
            Nodes = new List<Node>();
            Links = new List<Link>();
        }

        public void AddNode(Node node)
        {
            node.Index = Nodes.Count;
            Nodes.Add(node);
        }

        public string Serialization()
        {
            var output = "";
            output += Nodes.Count + "\n";
            output += Links.Count + "\n";
            Nodes.ForEach(node =>
            {
                output += String.Format("{0},{1},{2}\n", node.Center.X, node.Center.Y, node.Text);
            });
            Links.ForEach(link =>
            {
                output += String.Format("{0},{1},{2}\n", link.FromNode.Index, link.ToNode.Index, link.Cost);
            });
            return output;
        }

        public void SaveIntoFile(string fileName)
        {
            File.WriteAllText(fileName, Serialization());
        }

        public string? ReadNextLine(StringReader reader)
        {
            var str = "";
            do
            {
                str = reader.ReadLine();
                if (str == null)
                {
                    return null;
                }
            } while (str == "");
            var commentIdx = str.IndexOf('#');
            if(commentIdx == -1)
            {
                return str;
            }
            return str.Substring(0, commentIdx).Trim();
        }

        public void Deserialize(string input)
        {
            Clear();
            using (StringReader reader = new StringReader(input))
            {
                var nodesStr = ReadNextLine(reader);
                var numNodes = int.Parse(nodesStr!);
                var linksStr = ReadNextLine(reader);
                var numLinks = int.Parse(linksStr!);
                var nodes = new List<Node>();
                for (int i = 0; i < numNodes; i++)
                {
                    var nodeStr = ReadNextLine(reader);
                    var nodeInfo = nodeStr.Split(',');
                    Nodes.Add(new Node(this, new System.Drawing.Point(int.Parse(nodeInfo[0]), int.Parse(nodeInfo[1])), nodeInfo[2]));
                }
                for(int i = 0; i < numLinks; i++)
                {
                    var linkStr = ReadNextLine(reader);
                    var linkInfo = linkStr.Split(',');
                    var fromNode = Nodes[int.Parse(linkInfo[0])];
                    var toNode = Nodes[int.Parse(linkInfo[1])];
                    Links.Add(new Link(this, fromNode, toNode, int.Parse(linkInfo[2])));
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            var input = File.ReadAllText(fileName);
            Deserialize(input);
        }

        public void ValidateNetwork(Network network, string fileName)
        {
            var save = network.Serialization();
            network.SaveIntoFile(fileName);
            network.LoadFromFIle(fileName);
            var load = network.Serialization();
        }
    
    }
}
