using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationKatas;
using FluentAssertions;

namespace CommunicationKatasTest
{
    internal class CryptographyTests
    {
        Cryptography testEncoder = new Cryptography();
        
        [Test]
        public void ROT13Test()
        {
            string result1 = testEncoder.ROT13Encoder("northcoders"); // should be "abegupbqref"
            string result2 = testEncoder.ROT13Encoder("abegupbqref"); // should be "northcoders"
            string result3 = testEncoder.ROT13Encoder("I'm sure glad nobody can read my secret ROT13 code."); // should return "V'z fher tynq abobql pna ernq zl frperg EBG13 pbqr."

            result1.Should().Be("abegupbqref");
            result2.Should().Be("northcoders");
            result3.Should().Be("V'z fher tynq abobql pna ernq zl frperg EBG13 pbqr.");
        }

    }
}
