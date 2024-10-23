using Services;
using Shared;
using System.Collections;
namespace CustomLinkedList;

#nullable disable
public class LinkedListCustom<T> : IEnumerable
{
    public LinkedListCustom() => _head = default;
    public int Count => _count;
    public T First => _head!.Value;

    private Node<T> _head = default;
    private ServiceManager<T> _serviceManager = new();
    private int _count = 0;

    public void AddFirst(T value) => _serviceManager.AddService.FirstAdd(value, ref _head, ref _count);

    public void AddAfter(T existingValue, T newValue) => _serviceManager.AddService.AfterAdd(ref _head, existingValue, newValue, ref _count);

    public void AddBefore(T existingValue, T newValue) => _serviceManager.AddService.BeforeAdd(ref _head, existingValue, newValue, ref _count);

    public void AddLast(T value) => _serviceManager.AddService.LastAdd(ref _head, value, ref _count);

    public void RemoveFirst() => _serviceManager.RemoveService.FirstRemove(ref _head, ref _count);

    public IEnumerator GetEnumerator() => _serviceManager.GetService.GetAll(_head);
}
