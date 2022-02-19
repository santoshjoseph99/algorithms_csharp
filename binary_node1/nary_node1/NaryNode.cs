using System;
using System.Collections.Generic;
using System.Linq;

namespace nary_node1
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

        public override string ToString()
        {
            // my_value: child1_value child2_value child3_value ...
            var children = "";
            Children.ForEach(c => children += " " + c.Value.ToString());
            return Value.ToString() + ":" + children;
        }
    }
}
