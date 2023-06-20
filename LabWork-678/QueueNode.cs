using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_678
{
    internal class QueueNode<T>
    {
        public T? Value { get; set; }
        public  QueueNode<T>? NextNode;

        public QueueNode(T value)
        {
            Value = value;
        }
    }
}
