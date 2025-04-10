using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExercises.Utilities.Queues
{
    public class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public void Push(object item)
        {
            if(item  == null) 
                throw new InvalidOperationException("item cannot be null");
            _stack.Add(item);
        }
        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("The stack is empty and cannot extract any more items");
            var index = _stack.Count - 1;
            var item = _stack[index];
            _stack.RemoveAt(index);
            return item;
        }
        public void Clear()
        {
            _stack.Clear();
        }
    }
}
