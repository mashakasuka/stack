using System;
class Stack
{
    char[] stck;
    int tos;

    public Stack(int size)
    {
        stck = new char[size];
        tos = 0;
    }

    public void Push(char ch)
    {
        if (tos == stck.Length)
        {
            Console.WriteLine(" - Стек заполнен.");
            return;
        }

        stck[tos] = ch;
        tos++;
    }

    public char Pop()
    {
        if (tos == 0)
        {
            Console.WriteLine(" - Стек пуст");
            return (char)0;
        }

        tos--;
        return stck[tos];
    }

    public bool IsFull()
    {
        return tos == stck.Length;
    }

    public bool IsEmpty()
    {
        return tos == 0;
    }

    public int Capacity()
    {
        return stck.Length;
    }

    public int GetNum()
    {
        return tos;
    }

    class StackDemo
    {
        static void Main()
        {
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            char ch;
            int i;

            Console.WriteLine("Поместить символы A-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));
            if (stk1.IsFull()) Console.WriteLine("Стек stk1 заполнен.");

            Console.Write("Содержимое стека stk1: ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }

            Console.WriteLine();

            if (stk1.IsEmpty()) Console.WriteLine("Стек stk1 пустой.");

            Console.WriteLine("Вновь поместить символы A-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));

            Console.WriteLine("А теперь извлечь символы из стека stk1\n" +
                            "и поместить их в стек stk2.");
            while(!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                stk2.Push(ch);
            }

            Console.Write("Содержимое стека stk2: ");
            while(!stk2.IsEmpty())
            {
                ch = stk2.Pop();
                Console.Write(ch);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Поместить 5 символов в стек stk3.");
            for (i = 0; i < 5; i++)
                stk3.Push((char)('A' + i));

            Console.WriteLine("Емкость стека stk3: " + stk3.Capacity());
            Console.WriteLine("Количество объектов в стеке stk3: " + stk3.GetNum());
        }
    }
}