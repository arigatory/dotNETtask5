using System;
using System.Diagnostics.Eventing.Reader;

namespace dotNETtask5
{
    public class Stack<T>
    {
        private Node<T> _first, _last;
        public void Push(T data)
        {
            Node<T> temp = new Node<T>(data);
            if (_last == null)
            {
                _last = temp;
                _first = temp;
            }
            else
            {
                temp.Next = _first;
                _first = temp;
            }
        }

        public T Pop()
        {
            if (_last == null)
            {
                return default(T);
            }

            Node<T> temp;
            if (_last == _first)
            {
                temp = _first;
                _first = _last = null;
                return temp.Data;
            }

            temp = _first;
            _first = _first.Next;
            return temp.Data;
        }

        public int Count()
        {
            int res = 0;
            Node<T> temp = _first;
            while (temp != null)
            {
                res++;
                temp = temp.Next;
            }
            return res;
        }

        public T Top()
        {
            return _first.Data;
        }

        private class Node<TVal>
        {
            public Node(TVal data, Node<TVal> next = null)
            {
                Data = data;
                Next = next;
            }

            public TVal Data { get; set; }
            public Node<TVal> Next { get; set; }
        }
    }
}
