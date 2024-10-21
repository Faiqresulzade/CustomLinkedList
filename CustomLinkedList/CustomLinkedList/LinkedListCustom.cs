using Services;
using Shared;
using System.Collections;
namespace CustomLinkedList;

#nullable disable
public class LinkedListCustom<T> : IEnumerable
{
    public LinkedListCustom() => _head = default;
    public Node<T> First => _head!;

    private Node<T> _head = default;
    private ServiceManager<T> _serviceManager = new();

    public void AddFirst(T value) => _serviceManager.AddService.FirstAdd(value, ref _head);

    public void AddAfter(T existingValue, T newValue) => _serviceManager.AddService.AfterAdd(ref _head, existingValue, newValue);

    public void AddBefore(T existingValue, T newValue) => _serviceManager.AddService.BeforeAdd(ref _head, existingValue, newValue);

    public void AddLast(T value) => _serviceManager.AddService.LastAdd(ref _head, value);

    public void RemoveFirst() => _serviceManager.RemoveService.FirstRemove(ref _head);

    public IEnumerator GetEnumerator() => _serviceManager.GetService.GetAll(_head);
}
