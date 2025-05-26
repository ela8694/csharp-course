using System.Threading;

namespace DataStructures
{
    // DoublyLinkedList
    public class DoublyLinkedList<T> where T : IEquatable<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; } = null!;
            public Node Prev { get; set; } = null!;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? _head;
        private Node? _tail;
        private int _count;

        public void AddFirst(T value)
        {
            var newNode = new Node(value);

            if (_head == null)
            {
                _head = _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head.Prev = newNode;
                _head = newNode;
            }

            _count++;
        }

        public void AddLast(T value)
        {
            var newNode = new Node(value);

            if (_tail == null)
            {
                _head = _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Prev = _tail;
                _tail = newNode;
            }

            _count++;
        }

        public bool TryRemove(T value)
        {
            var current = _head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        _head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev!;
                    }
                    else
                    {
                        _tail = current.Prev;
                    }

                    _count--;

                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public bool Contains(T value)
        {
            if (_count == 0) return false;

            if (value.Equals(_head.Value) || value.Equals(_tail.Value))
                return true;

            var current = _head;
            if (_count / 2 <= _count - 1)
            {
                current = _tail;
                while (current != null)
                {
                    if (current.Value.Equals(value)) return true;
                    current = current.Prev;
                }
            }
            else
            {
                current = _head;
                while (current != null)
                {
                    if (current.Value.Equals(value)) return true;
                    current = current.Next;
                }
            }
            return false;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            Node current;

            if (index < _count / 2)
            {
                current = _head;
                for (int i = 0; i < index; i++)
                {
                    current = current!.Next;
                }
            }
            else
            {
                current = _tail;
                for (int i = _count - 1; i > index; i--)
                {
                    current = current!.Prev;
                }
            }

            return current!.Value;
        }

        public T[] ToArray()
        {
            var result = new T[_count];
            var current = _head;

            for (int i = 0; i < _count; i++)
            {
                result[i] = current.Value;
                current = current.Next;
            }

            return result;
        }

        public T[] ToReversedArray()
        {
            var result = new T[_count];
            var current = _tail;

            for (int i = _count - 1; i >= 0; i--)
            {
                result[i] = current.Value;
                current = current.Prev;
            }

            return result;
        }

        public int Count()
        {
            return _count;
        }
    }
}
