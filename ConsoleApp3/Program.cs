using System;

public  class BaseClass
{
    public int number;
    public string text;

    public BaseClass(int number, string text)
    {
        number = number;
        text = text;
    }
}

public class ChildClass1 : BaseClass
{
    public bool flag;

    public ChildClass1(int number, string text, bool flag) : base(number, text)
    {
        flag = flag;
    }
}

public class ChildClass2 : BaseClass
{
    public decimal value;

    public ChildClass2(int number, string text, decimal value) : base(number, text)
    {
        value = value;
    }
}

class Program
{
    static void Main()
    {
        BaseClass baseObj = new BaseClass(5, "Hello");
        ChildClass1 childObj1 = new ChildClass1(10, "World", true);
        ChildClass2 childObj2 = new ChildClass2(20, "Foo", 3.14m);

        // Пример использования данных из конструкторов:
        Console.WriteLine($"BaseClass: {baseObj.number}, {baseObj.text}");
        Console.WriteLine($"ChildClass1: {childObj1.number}, {childObj1.text}, {childObj1.flag}");
        Console.WriteLine($"ChildClass2: {childObj2.number}, {childObj2.text}, {childObj2.value}");
    }
}