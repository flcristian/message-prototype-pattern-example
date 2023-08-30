using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_prototype_pattern_example
{
    public class Message : IPrototype<Message>
    {
        private String _content;
        private String _color;

        // Constructors

        public Message()
        {
            _content = String.Empty;
            _content = "White";
        }

        public Message(String content, String color)
        {
            _content = content;
            _color = color;
        }

        public Message(Message message)
        {
            _content = message._content;
            _color = message._color;
        }

        // Accessors

        public String Content
        {
            get { return _content; }
            set
            {
                _content = value;
            }
        }

        public String Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        // Methods

        public override Boolean Equals(object? obj)
        {
            Message message = obj as Message;
            return message._content == _content && message._color == _color;
        }

        public override String ToString()
        {
            String desc = "";
            desc += $"LOG : {_content}\n";
            return desc;
        }

        public virtual void Log()
        {
            ConsoleColor color = 0;
            Enum.TryParse(_color, true, out color);
            Console.ForegroundColor = color;
            Console.WriteLine(this);

            Console.ForegroundColor = ConsoleColor.White;
        }

        public virtual Message Clone()
        {
            return new Message(this);
        }
    }
}
