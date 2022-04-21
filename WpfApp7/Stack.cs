using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    public class Stack<T> : LinkedList<T>
    {
        
        public void Push(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                tail = head;
            }
            else
            {
                Node<T> currenthead = head;
                head = new Node<T>(data);
                head.Next = currenthead;
            }
            count++;
        }
        public T Pop()
        {
            if (head == null)
            {
                return default(T);
            }
            count--;
            Node<T> currenthead = head;
            if (currenthead.Next == null)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
            }
            return currenthead.Data;

        }
    }
}
