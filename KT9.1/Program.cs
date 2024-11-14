public class Stack<T> where T : IComparable<T>
{
    private List<T> elements;
    public Stack()
    {
        elements = new List<T>();
    }

    public void Push(T item)
    {
        elements.Add(item);
    }

    public T Pop()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("Стек пуст.");

        T item = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("Стек пуст.");

        return elements[elements.Count - 1];
    }

    public T Max()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("Стек пуст.");

        T max = elements[0];
        foreach (var item in elements)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }

    public int Count => elements.Count;
    public bool IsEmpty => elements.Count == 0;
}


public class Program
{
    public static void Main()
    {
        Stack<int> intStack = new Stack<int>();

        intStack.Push(10);
        intStack.Push(30);
        intStack.Push(20);

        Console.WriteLine($"Максимальный элемент: {intStack.Max()}"); 

        int popped = intStack.Pop();
        Console.WriteLine($"Удален элемент: {popped}"); 

        Console.WriteLine($"Максимальный элемент: {intStack.Max()}"); 
    }
}