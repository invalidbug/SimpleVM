using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.cs;

namespace Simple_VM {
    public class Program {
        static void Main(string[] args) {
            Dictionary<string, IInstruction> instructionTypes = new Dictionary<string, IInstruction>();
            /*/         for every iinstruction instance in file
                            instructiontypes.add(x.operator, x);
                        end
            /*/

            // the main Script
            string assembly = @"
SET x, 1000
GET x
ADD x, 5
SUB x, 3
MUL x, 1
DIV x, 8
PRINT x
";
            // lets get rid of those disgusting commas.
            assembly = assembly.Replace(",", "");

            List<string> bytecode = new List<string>();

            char[] newLine = Environment.NewLine.ToCharArray();
            foreach (string line in assembly.Split(newLine)) {
                // we want to know whats inbetween the spaces so we can parse to byte code :)
                string[] instruction = line.Split(' ');
                // Operator
                IInstruction i = instructionTypes[instruction[0]];
                bytecode.Add(Convert.ToString(i.bytecode,2));
                for (int j = 0; j < i.paramCount; j++) {
                    //byte[] l = Encoding.ASCII.GetBytes()
                    //bytecode.Add(binary);
                }
            }

        }
    }
}
