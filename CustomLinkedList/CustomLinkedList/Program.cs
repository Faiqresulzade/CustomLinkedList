
using CustomLinkedList;
LinkedList<int> test = new LinkedList<int>();
//test.AddFirst(1);
//test.AddFirst(2);
//test.AddFirst(3);
//test.AddFirst(4);
//test.AddLast(9);
//foreach (var item in test)
//{
//    Console.WriteLine(item);
//}

LinkedListCustom<int> list = new LinkedListCustom<int>();
list.AddFirst(1);
list.AddFirst(2);
list.AddFirst(3);
list.AddLast(4);
list.RemoveFirst();
foreach (var item in list)
{
    Console.WriteLine(item);
}