using System;
namespace binary_node2
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
    }
}
