using System;
namespace Memento
{
    public class EditorState
    {

        public string Content { get; }

        public EditorState(string Content)
        {
            this.Content = Content;
        }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            //Content = state.Content;
        }

    }
}
