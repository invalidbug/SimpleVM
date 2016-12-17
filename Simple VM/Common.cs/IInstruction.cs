using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.cs
{
    public interface IInstruction {
        void Process(object[] args);
        string Operator { get; set; }
        int bytecode { get; set; }
        int paramCount { get; set; }
    }
}
