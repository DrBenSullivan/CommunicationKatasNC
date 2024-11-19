using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationKatas
{
    public class Cryptography
    {
        public string ROT13Encoder(string message)
        {
            string result = "";

            foreach (char c in message)
            {
                int start = 0;
                int end = 0;

                if (Char.IsUpper(c))
                {
                    start = (int)'A';
                    end = (int)'Z';
                }

                else if (Char.IsLower(c))
                {
                    start = (int)'a';
                    end = (int)'z';
                } else { result += c; continue; }

                int current = (int)c;
                current += 13;

                if (current > end)
                {
                    current -= end;
                    current += start - 1;
                    result += (char)current;
                }
                else
                {
                    result += (char)current;
                }

            }

            return result;
        }
    }
}
