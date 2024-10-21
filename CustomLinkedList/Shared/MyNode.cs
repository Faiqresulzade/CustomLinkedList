namespace Shared;
#nullable disable
public sealed class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Prev { get; set; }

    public Node()
    {
        
    }

    public Node(T value)
    {
        Value = value;
        Next = default!;
    }

    public Node(T value, Node<T> next)
    {
        Value = value;
        Next = next;
    }

    public Node(T value, Node<T> next, Node<T> prev)
    {
        Value = value;
        Next = next;
        Prev = prev;
    }
}