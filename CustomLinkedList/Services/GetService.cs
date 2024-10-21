namespace Services;

public class GetService<T> : SingletonBase<GetService<T>>, IGetService<T>
{
    public IEnumerator<T> GetAll(Node<T>? head)
    {
        var current = head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }
}
