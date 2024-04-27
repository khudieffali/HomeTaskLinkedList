
using HomeTaskLinkedList;

int[] arr = { 5, 8, 9, 10, 11, 12 };
MyStack<int> st = new MyStack<int>(arr);

st.Pop();
Console.WriteLine("Stack Pop element : ");
Console.WriteLine(st.Pop());


Console.WriteLine("----------------------------------");
Console.WriteLine("Stack Peek element");
Console.WriteLine(st.Peek());


Console.WriteLine("----------------------------------");
Console.WriteLine("Stack's elements :");
foreach (var item in st)
{
    Console.WriteLine(item);

}


Console.WriteLine("----------------------------------");
Console.WriteLine($"Capacity: {st.Capacity}");

Console.WriteLine("----------------------------------");
Console.WriteLine($"Count: {st.Count}");


