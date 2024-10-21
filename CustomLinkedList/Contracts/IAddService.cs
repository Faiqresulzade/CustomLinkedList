using Shared;

namespace Contracts
{
    public interface IAddService<T>
    {
        void FirstAdd(T value, ref Node<T>? head);
        void LastAdd(ref Node<T> head, T value);
        void AfterAdd(ref Node<T> current, T existingValue, T newValue);
        void BeforeAdd(ref Node<T>? head, T existingValue, T newValue);
    }
}