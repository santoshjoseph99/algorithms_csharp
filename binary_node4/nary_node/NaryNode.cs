using System;
using System.Collections.Generic;
using System.Linq;

namespace nary_node3
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

        public bool FindNode(T value)
        {
            if(Value.Equals(value))
            {
                return true;
            }
            foreach(var child in Children)
            {
                if(child.Equals(value))
                {
                    return true;
                }
            }
            foreach (var child in Children)
            {
                if (child.FindNode(value))
                {
                    return true;
                }
            }
            return false;
        }


        public List<NaryNode<T>> TraversePreorder()
        {
            List<NaryNode<T>> result = new List<NaryNode<T>>();

            result.Add(this);

            foreach(var child in Children)
            {
                result.AddRange(child.TraversePreorder());
            }
            
            return result;
        }

        public List<NaryNode<T>> TraversePostorder()
        {
            List<NaryNode<T>> result = new List<NaryNode<T>>();

            foreach (var child in Children)
            {
                result.AddRange(child.TraversePreorder());
            }
            result.Add(this);

            return result;
        }

        public List<NaryNode<T>> TraverseBreadthFirst()
        {
            List<NaryNode<T>> result = new List<NaryNode<T>>();
            Queue<NaryNode<T>> queue = new Queue<NaryNode<T>>();

            queue.Enqueue(this);
            while (queue.Count != 0)
            {
                var item = queue.Dequeue();
                result.Add(item);
                foreach(var child in item.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return result;
        }
    }
}
