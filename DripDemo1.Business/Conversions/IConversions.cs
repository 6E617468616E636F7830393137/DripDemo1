using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DripDemo1.Business.Conversions
{
    public interface IStringToHexConversion
    {
        string StringToHexConversion32(string input);
        string StringToHexConversion8(string input);
        string StringToHexConversion7(string input);
    }
    public interface IHexToStringConversion
    {
        string HexToStringConversion32(string input);
        string HexToStringConversion8(string input);
        string HexToStringConversion7(string input);
    }
    public interface IHexToDecimalConversion
    {
        string HexToDecimalConversion32(string input);
        string HexToDecimalConversion8(string input);
        string HexToDecimalConversion7(string input);
    }
}
