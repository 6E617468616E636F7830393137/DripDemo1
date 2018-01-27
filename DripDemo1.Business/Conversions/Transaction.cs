
using Log = Log4net.Helper.Logging.Logger;

namespace DripDemo1.Business.Conversions
{
    public class Transaction
    {
        public class StringToHexExecute : IStringToHexConversion
        {
            public string StringToHexConversion32(string input)
            {
                Log.Debug("String to Hex conversion UTF32");
                return new Transactions.StringToHex().ConversionUTF32(input);
            }
            public string StringToHexConversion8(string input)
            {
                return new Transactions.StringToHex().ConversionUTF8(input);
            }
            public string StringToHexConversion7(string input)
            {
                return new Transactions.StringToHex().ConversionUTF7(input);
            }
        }
        public class HexToStringExecute : IHexToStringConversion
        {
            public string HexToStringConversion32(string input)
            {
                return new Transactions.HexToString().ConversionUTF32(input);
            }
            public string HexToStringConversion8(string input)
            {
                return new Transactions.HexToString().ConversionUTF8(input);
            }
            public string HexToStringConversion7(string input)
            {
                return new Transactions.HexToString().ConversionUTF7(input);
            }
        }
        public class HexToDecimalExecute : IHexToDecimalConversion
        {
            public string HexToDecimalConversion32(string input)
            {
                return new Transactions.HexToDecimal().ConversionUTF32(input);
            }
            public string HexToDecimalConversion8(string input)
            {
                return new Transactions.HexToDecimal().ConversionUTF8(input);
            }
            public string HexToDecimalConversion7(string input)
            {
                return new Transactions.HexToDecimal().ConversionUTF7(input);
            }
        }

    }
}
