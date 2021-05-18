using System;
using System.Collections;

class MyStackArray
{
    private ArrayList array;

    public MyStackArray()
    {
        array = new ArrayList();
    }

    public int peek()
    {
        if (this.array.Count > 0)
            return (int)this.array[this.array.Count - 1];
        return -100000; //returning -100000 if length is 0
    }

    public void push(int value)
    {
        this.array.Add(value);
    }

    public int pop()
    {
        if (this.array.Count == 0)
        {
            return -100000;
        }
        int lastItem = (int)this.array[this.array.Count - 1];
        this.array.RemoveAt(this.array.Count - 1);
        return lastItem;
    }

    public void printStack()
    {
        for(int i = this.array.Count-1; i>=0 ; i--)
        {
            Console.WriteLine(this.array[i]);
        }
    }

}