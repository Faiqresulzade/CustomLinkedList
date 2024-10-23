using Shared;

namespace Contracts
{
    public interface IAddService<T>
    {
        void FirstAdd(T value, ref Node<T>? head,ref int count);
        void LastAdd(ref Node<T> head, T value, ref int count);
        void AfterAdd(ref Node<T> current, T existingValue, T newValue, ref int count);
        void BeforeAdd(ref Node<T>? head, T existingValue, T newValue, ref int count);
    }
}