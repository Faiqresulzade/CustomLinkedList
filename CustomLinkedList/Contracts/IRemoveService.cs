using Shared;

namespace Contracts;

public interface IRemoveService<T>
{
    void FirstRemove(ref Node<T> head);
    void LastRemove(ref Node<T> head);
}
