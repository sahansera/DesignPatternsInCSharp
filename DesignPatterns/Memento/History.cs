using System;
using System.Collections.Generic;

namespace Memento
{
    public class History
    {
        public Stack<EditorState> PrevStates { get; set; }

        public History()
        {
            PrevStates = new Stack<EditorState>();
        }

        public void Push(EditorState State)
        {
            PrevStates.Push(State);
        }

        public EditorState Pop()
        {
            return PrevStates.Pop();
        }

        public EditorState Peek()
        {
            return PrevStates.Peek();
        }
    }
}
