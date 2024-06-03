using AudioRepeater;
using System;
using System.Windows.Input;

namespace AudioRepeater
{
    public class HotKeyWithAction : IDisposable
    {

        public HotKeyWithAction(ModifierKeys modifier, Key key, Action action, int id, IntPtr window)
        {
            Modifier = modifier;
            Key = key;
            Action = action;
            Id = id;
            this.window = window;
        }

        public ModifierKeys Modifier { get; }
        public Key Key { get; }
        public Action Action { get; }
        public int? Id { get; private set; }

        private IntPtr window;

        public void Dispose()
        {
            var i = Id;
            if (i != null)
            {
                Id = null;
                NativeMethods.UnregisterHotKey(window, i.Value);
            }
        }
    }
}