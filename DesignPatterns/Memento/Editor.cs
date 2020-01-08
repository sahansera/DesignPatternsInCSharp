using System;
namespace Memento
{
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState editorState)
        {
            this.Content = editorState.Content;
        }
    }
}
