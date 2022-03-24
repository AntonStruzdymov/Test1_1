using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1Library
{
    public class MyStack
    {
        int[] _stack = new int[0];

        public void Push(int value)
        {
            int[] temp = new int[_stack.Length+1];
            for (int i = 0; i < _stack.Length; i++)
            {
                temp[i] = _stack[i];
            }
            temp[_stack.Length] = value;
            _stack = temp;
        }
        public int Pop()
        {
            int value = _stack[_stack.Length-1];
            int[] temp = new int[_stack.Length-1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = _stack[i];
            }
            _stack = temp;
            return value;
        }
    }
}
