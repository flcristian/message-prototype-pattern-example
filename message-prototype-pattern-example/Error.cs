using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_prototype_pattern_example
{
    public class Error : Message
    {
        private Int32 _code;
        
        // Constructors

        public Error() : base()
        {
            _code = 400;
            Color = "Red";
        }
        
        public Error(String content, Int32 code) : base(content, "Red")
        {
            _code = code;
        }

        public Error(Error error) : base(error)
        {
            _code = error._code;
            Color = "Red";
        }

        // Accessors

        public Int32 Code
        {
            get { return _code; }
            set
            {
                _code = value;
            }
        }

        // Methods

        public override Boolean Equals(object? obj)
        {
            return base.Equals(obj) && (obj as Error)._code == _code;
        }

        public override String ToString()
        {
            String desc = "";
            desc += $"ERROR {_code} : {Content}\n";
            return desc;
        }

        public override void Log()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(this);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override Error Clone()
        {
            return new Error(this);
        }
    }
}
