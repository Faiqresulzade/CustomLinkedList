namespace Services;

public class RemoveService<T> : SingletonBase<RemoveService<T>>, IRemoveService<T>
{
    public void FirstRemove(ref Node<T> head,ref int count)
    {
        head = head.Next;
        head.Prev = null;
        count--;
    }

    public void LastRemove(ref Node<T> head,ref int count)
    {
        throw new NotImplementedException();
    }
}
