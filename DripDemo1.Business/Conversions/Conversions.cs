using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DripDemo1.Business.Conversions
{
    public class Conversions
    {
        //Declarations
        private readonly IStringToHexConversion _stringToHexConversion;
        private readonly IHexToDecimalConversion _hexToDecimalConversion;
        private readonly IHexToStringConversion _hexToStringCoversion;
        //Constructors
        public Conversions(IStringToHexConversion concreteImplementation)
        {
            _stringToHexConversion = concreteImplementation;
        }
        public Conversions(IHexToStringConversion concreteImplementation)
        {
            _hexToStringCoversion = concreteImplementation;
        }
        public Conversions(IHexToDecimalConversion concreteImplementation)
        {
            _hexToDecimalConversion = concreteImplementation;
        }
        //Implementations
        public string StringToHex32(string input)
        {
            return _stringToHexConversion.StringToHexConversion32(input);
        }
        public string StringToHex8(string input)
        {
            return _stringToHexConversion.StringToHexConversion8(input);
        }
        public string StringToHex7(string input)
        {
            return _stringToHexConversion.StringToHexConversion7(input);
        }

        public string HexToString32(string input)
        {
            return _hexToStringCoversion.HexToStringConversion32(input);
        }
        public string HexToString8(string input)
        {
            return _hexToStringCoversion.HexToStringConversion8(input);
        }
        public string HexToString7(string input)
        {
            return _hexToStringCoversion.HexToStringConversion8(input);
        }

        public string HexToDecimal32(string input)
        {
            return _hexToDecimalConversion.HexToDecimalConversion32(input);
        }
        public string HexToDecimal8(string input)
        {
            return _hexToDecimalConversion.HexToDecimalConversion8(input);
        }
        public string HexToDecimal7(string input)
        {
            return _hexToDecimalConversion.HexToDecimalConversion7(input);
        }        
    }
}
