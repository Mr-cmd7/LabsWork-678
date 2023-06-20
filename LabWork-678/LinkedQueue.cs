using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_678
{
    internal class LinkedQueue<T> : IEnumerable<T>

    {
        public QueueNode<T>? Head { get; set; }

        int count;

        public void Enqueue (T data)
        {

            QueueNode<T> node = new QueueNode<T>(data);
            if(Head == null)
                Head = node;
            else
            {
                var current = Head;
               while(current.NextNode != null)
                {
                    current = current.NextNode;
                }
               current.NextNode = node;
            }
            count++;
        }

        public T? Dequeue () 
        {
            if (Head != null)
            {
                var node = Head;
                Head = Head.NextNode;
                return node.Value;
            }
            return default;
        }

        public IEnumerator<T> GetEnumerator()
        {
            QueueNode<T>? current = Head;
            while (current != null && current.Value != null)
            {
                yield return current.Value;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
