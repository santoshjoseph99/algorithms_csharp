using System;
using System.Collections.Generic;
using System.Linq;

namespace nary_node2
{
    public class NaryNode<T>
    {
        public T Value { get; set; }
        public List<NaryNode<T>> Children { get; set; }

        public NaryNode(T value)
        {
            Value = value;
            Children = new List<NaryNode<T>>();
        }

        public void AddChild(NaryNode<T> value)
        {
            Children.Add(value);
        }

        public string ToString(String spaces)
        {
            var str = spaces + Value + ":\n";
            Children.ForEach(c => str += c.ToString(spaces + "  "));
            return str;


        }

        public override string ToString()
        {
            return ToString("");
        }
    }
}
