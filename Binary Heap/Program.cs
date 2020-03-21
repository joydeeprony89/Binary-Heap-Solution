using System;

namespace Binary_Heap
{
    public class BinaryHeap
    {
        int capacity;
        int currectSize;

        public BinaryHeap(int capacity)
        {
            this.capacity = capacity;
        }

        public int rootElement(int position)
        {
            return (position - 1) / 2;
        }

        public int leftChild(int position)
        {
            return (position * 2) + 1;
        }

        protected int rightChild(int position)
        {
            return (position * 2) + 2;
        }

    }
    class Program : BinaryHeap
    {
        const int HEAP_CAPACITY = 10;
        Program() : base(HEAP_CAPACITY)
        {

        }
        static void Main(string[] args)
        {
            BinaryHeap heap = new BinaryHeap(HEAP_CAPACITY);
            Console.WriteLine("Hello World!");
        }
    }
}
