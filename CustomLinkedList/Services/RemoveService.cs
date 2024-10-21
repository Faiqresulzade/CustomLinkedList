namespace Services;

public class RemoveService<T> : SingletonBase<RemoveService<T>>, IRemoveService<T>
{
    public void FirstRemove(ref Node<T> head)
    {
        head = head.Next;
        head.Prev = null;
    }

    public void LastRemove(ref Node<T> head)
    {
        throw new NotImplementedException();
    }
}
