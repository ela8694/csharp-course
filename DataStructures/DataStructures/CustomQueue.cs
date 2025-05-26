namespace DataStructures
{
    // FIFO
    public class CustomQueue<T>
    {
        private LinkedList<T> _items = new LinkedList<T>();
        private int _count = 0;

        public int Count => _count;

        public void Enqueue(T item)
        {
            _items.AddLast(item);
            _count++;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T value = _items.First.Value;
            _items.RemoveFirst();
            _count--;
            return value;
        }

        public T Peek()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return _items.First.Value;
        }

        public bool IsEmpty() => true;

        public T[] ToArray()
        {
            T[] array = new T[_count];
            _items.CopyTo(array, 0);
            return array;
        }
    }
}
