using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_prototype_pattern_example
{
    public class Warning : Message
    {
        private String _severity;

        // Constructors

        public Warning() : base()
        {
            _severity = "Low";
            Color = "Yellow";
        }

        public Warning(String content, String severity) : base (content, "Yellow")
        {
            _severity = severity;
        }

        public Warning(Warning warning) : base(warning)
        {
            _severity = warning._severity;
        }

        // Accessors

        public String Severity
        {
            get { return _severity; }
            set
            {
                _severity = value;
            }
        }

        // Methods

        public override Boolean Equals(object? obj)
        {
            return base.Equals(obj) && (obj as Warning)._severity == _severity;
        }

        public override String ToString()
        {
            String desc = "";
            desc += $"WARNING | SEVERITY {_severity} : {Content}\n";
            return desc;
        }

        public override void Log()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(this);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override Warning Clone()
        {
            return new Warning(this);
        }
    }
}
