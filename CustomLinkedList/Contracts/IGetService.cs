using Shared;

namespace Contracts;

public interface IGetService<T>
{
    IEnumerator<T> GetAll(Node<T>? head);
}
