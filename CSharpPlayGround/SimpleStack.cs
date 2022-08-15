namespace CSharpPlayGround
{
    public class SimpleStack<T>
    {
        private const int Length = 10;

        private T[] Items;
        private int CurrentIndex = -1;
        public SimpleStack() => Items = new T[Length];
        public int Count => CurrentIndex + 1;


        public void Add(T item) => Items[++CurrentIndex] = item;
        public T Pop() => Items[CurrentIndex--];



    }
}