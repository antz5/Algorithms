using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*
             [X]  1) Create an empty stack.
             [X]  2) One by one push all characters of string to stack.
             [X]  3) One by one pop all characters from stack and put them back to string.
        */

    public class ReversingStringUsingStack
    {

        public string Reverse(string input)
        {

            Stack stack = new Stack(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            //Reverse logic - pop all chars and put them back to string s
            input = "";
            while (stack.top >= 0)
            {
                input += stack.Pop();
            }

            return input;
        }
    }
    public class Stack
    {
        public int top = -1;
        char[] array;

        public bool isStackEmpty()
        {
            return top == -1;
        }

        public bool isStackFull()
        {
            return top == array.Length - 1;
        }
        public Stack(int capacity)
        {
            array = new char[capacity];
        }

        public void Push(char data)
        {
            if (!isStackFull())
            {
                array[++top] = data;
            }
        }

        public char Pop()
        {
            return array[top--];
        }
    }
}
