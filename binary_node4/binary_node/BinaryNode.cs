using System;
using System.Collections;
using System.Collections.Generic;

namespace binary_node
{
    public class BinaryNode<T>
    {
        public T Value { get; set; }
        public BinaryNode<T> LeftChild { get; set; }
        public BinaryNode<T> RightChild { get; set; }

        public BinaryNode(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        public void AddLeft(BinaryNode<T> left)
        {
            LeftChild = left;
        }

        public void AddRight(BinaryNode<T> right)
        {
            RightChild = right;
        }
 
        string ToString(String spaces)
        {
            var str = spaces + Value + ":\n";
            if(LeftChild == null && RightChild == null)
            {
                return str;
            }

            if(LeftChild != null) {
                str += LeftChild.ToString(spaces + "  ");
            }
            else
            {
                str += spaces + "  " + "None\n";
            }

            if(RightChild != null)
            {
                str += RightChild.ToString(spaces + "  ");
            }
            else
            {
                str += spaces + "  " + "None\n";
            }

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
            if (LeftChild != null)
            {
                var result = LeftChild.FindNode(value);
                if (result)
                {
                    return true;
                }
            }
            if (RightChild != null)
            {
                return RightChild.FindNode(value);
            }
            return false;
        }

        public List<BinaryNode<T>> TraversePreorder()
        {
            List<BinaryNode<T>> result = new List<BinaryNode<T>>();

            result.Add(this);

            if (LeftChild != null)
            {
                result.AddRange(LeftChild.TraversePreorder());
            }
            if (RightChild != null)
            {
                result.AddRange(RightChild.TraversePreorder());
            }
            return result;
        }

        public List<BinaryNode<T>> TraverseInorder()
        {
            List<BinaryNode<T>> result = new List<BinaryNode<T>>();
            if (LeftChild != null)
            {
                result.AddRange(LeftChild.TraversePreorder());
            }
            result.Add(this);
            if (RightChild != null)
            {
                result.AddRange(RightChild.TraversePreorder());
            }
            return result;
        }

        public List<BinaryNode<T>> TraversePostorder()
        {
            List<BinaryNode<T>> result = new List<BinaryNode<T>>();
           
            if (LeftChild != null)
            {
                result.AddRange(LeftChild.TraversePreorder());
            }
            if (RightChild != null)
            {
                result.AddRange(RightChild.TraversePreorder());
            }
            result.Add(this);

            return result;
        }

        public List<BinaryNode<T>> TraverseBreadthFirst()
        {
            List<BinaryNode<T>> result = new List<BinaryNode<T>>();
            Queue<BinaryNode<T>> queue = new Queue<BinaryNode<T>>();

            queue.Enqueue(this);
            while(queue.Count != 0)
            {
                var item = queue.Dequeue();
                result.Add(item);
                if(item.LeftChild != null)
                {
                    queue.Enqueue(item.LeftChild);
                }
                if(item.RightChild != null)
                {
                    queue.Enqueue(item.RightChild);
                }
            }
            return result;
        }
    }
}
