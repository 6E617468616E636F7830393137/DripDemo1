using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DripDemo1.Business.Conversions.Transactions
{
    public class HexToDecimal
    {
        internal string ConversionUTF32(string HexValue)
        {
            byte[] bytes = new byte[HexValue.Length];
            int pos = 8;
            long decimalValue = 0;
            string decimalValueOutput = "";
            string tempValue = "";
            for (int i = 0; i < bytes.Length; i += 1)
            {
                bytes[i] = (Convert.ToByte(HexValue.Substring(i, 1), 16));
                decimalValue += bytes[i] * Convert.ToInt64(Math.Pow(16, (pos - 1 - i % pos)));
                if (i % pos == pos - 1)
                {
                    tempValue += decimalValue;
                    decimalValueOutput += tempValue.PadLeft(pos + 2, '0') + " ";
                    tempValue = "";
                    decimalValue = 0;
                }
            }
            return decimalValueOutput;
        }//closes method
        internal string ConversionUTF8(string HexValue)
        {
            byte[] bytes = new byte[HexValue.Length];
            int pos = 2;
            long decimalValue = 0;
            string decimalValueOutput = "";
            string tempValue = "";

            for (int i = 0; i < bytes.Length; i += 1)
            {
                bytes[i] = (Convert.ToByte(HexValue.Substring(i, 1), 16));
                decimalValue += bytes[i] * Convert.ToInt64(Math.Pow(16, (pos - 1 - i % pos)));
                if (i % pos == pos - 1)
                {
                    tempValue += decimalValue;
                    decimalValueOutput += tempValue.PadLeft(pos + 2, '0') + " ";
                    tempValue = "";
                    decimalValue = 0;
                }
            }
            return decimalValueOutput;
        }
        internal string ConversionUTF7(string HexValue)
        {
            byte[] bytes = new byte[HexValue.Length];
            int pos = 2;
            long decimalValue = 0;
            string decimalValueOutput = "";
            string tempValue = "";

            for (int i = 0; i < bytes.Length; i += 1)
            {
                bytes[i] = (Convert.ToByte(HexValue.Substring(i, 1), 16));
                decimalValue += bytes[i] * Convert.ToInt64(Math.Pow(16, (pos - 1 - i % pos)));
                if (i % pos == pos - 1)
                {
                    tempValue += decimalValue;
                    decimalValueOutput += tempValue.PadLeft(pos + 2, '0') + " ";
                    tempValue = "";
                    decimalValue = 0;
                }
            }
            return decimalValueOutput;
        }
    }
}
