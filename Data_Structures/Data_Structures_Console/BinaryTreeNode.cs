using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    //public class B<T> where T : IComparable<T> { }
    //public class C { }
    //public class D { B<C> _var; }
    class BinaryTreeNode<TNode>: IComparable<TNode> where TNode:IComparable<TNode> //TNode Generic Inharitaged from IComparable(interface)
    {
        public BinaryTreeNode(TNode value) { Value = value; }
        public BinaryTreeNode<TNode> Left { get; set; }
        public BinaryTreeNode<TNode> Right { get; set; }
        public TNode Value { get; private set; }

        public int CompareTo(TNode other)//The generic definition has a where clause that tells the compiler that the actual TNode type must implement IComparable<TNode>. So, the compiler knows that the instanciated generic type has a CompareTo(...) method.
                                         //You can only instanciate BinaryTreeNode<...> with a type that fulfills that where constraint.E.g. string fulfills that constraint.
        {
            return Value.CompareTo(other);//If Value < other return -1
        }

        public int CompareNode(BinaryTreeNode<TNode> other)
        {
            var M = Value.CompareTo(other.Value);
            //Console.WriteLine(Value.CompareTo(other.Value).ToString());
            return M;
        }
    }
}
