using System;
namespace binary_node1
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

        public override string ToString()
        {
            // my_value: left_child_value right_child_value
            var left = LeftChild != null ? LeftChild.Value.ToString() : "null";
            var right = RightChild != null ? RightChild.Value.ToString() + ":" : "null";
            return String.Format("{0}: {1} {2}", Value, left, right);
        }
    }
}
