namespace Services;

public class AddService<T> : SingletonBase<AddService<T>>, IAddService<T>
{
    public void AfterAdd(ref Node<T> current, T existingValue, T newValue)
    {
        while (current is not null && !current.Value!.Equals(existingValue)) current = current.Next;

        if (current is null) throw new InvalidOperationException("Existing value not found in the list.");

        var newNode = new Node<T>(newValue, current.Next);
        current.Next = newNode;
        newNode.Prev = current;

        if (newNode.Next is not null) newNode.Next.Prev = newNode;
    }

    public void BeforeAdd(ref Node<T>? head, T existingValue, T newValue)
    {
        if (head is null) throw new InvalidOperationException("Linked list is empty.");

        if (head.Value!.Equals(existingValue))
        {
            FirstAdd(newValue, ref head);
            return;
        }

        Node<T>? current = head;
        while (current.Next is not null && !current.Next.Value!.Equals(existingValue)) current = current.Next;

        if (current.Next is null) throw new InvalidOperationException("Existing value not found in the list.");

        var newNode = new Node<T>(newValue, current.Next) { Next = current.Next };
        current.Next = newNode;
    }

    public void FirstAdd(T value, ref Node<T>? head)
    {
        var newNode = new Node<T>(value);

        if (head is not null)
        {
            newNode.Next = head;
            head.Prev = newNode;
        }

        head = newNode;
    }

    public void LastAdd(ref Node<T> head, T value)
    {
        if (head is null)
        {
            FirstAdd(value, ref head!);
            return;
        }
        var lastNode = head;
        while (lastNode.Next is not null) lastNode = lastNode.Next;

        var newLastNode = new Node<T>(value);
        lastNode.Next = newLastNode;
        newLastNode.Prev = lastNode;
    }
}