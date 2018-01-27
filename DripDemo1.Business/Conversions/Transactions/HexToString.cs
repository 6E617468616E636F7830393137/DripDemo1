using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DripDemo1.Business.Conversions.Transactions
{
    public class HexToString
    {
        internal string ConversionUTF32(string values)
        {
            //Reverse values by segments of 8         
            string reverseValues = "";
            string tmp = "";
            for (int i = 0; i < values.Length; i++)
            {
                tmp += values.Substring(i, 1);
                if (i % 8 == 7)
                {
                    reverseValues = tmp + reverseValues;
                    tmp = "";
                }
            }
            int ValuesLength = values.Length;
            byte[] bytes = new byte[ValuesLength / 2];
            int pos = 0;
            for (int i = ValuesLength - 2; i >= 0; i -= 2)
            {
                //Get reversed segments of values for byte array
                bytes[pos] = Convert.ToByte(reverseValues.Substring(i, 2), 16);
                pos++;
            }

            string val = Encoding.UTF32.GetString(bytes);
            return Encoding.UTF32.GetString(bytes);
        }
        internal string ConversionUTF8(string values)
        {
            int ValuesLength = values.Length;
            byte[] bytes = new byte[ValuesLength / 2];
            int pos = 0;
            //for (int i = ValuesLength - 2; i >= 0; i -= 2)
            for (int i = 0; i < ValuesLength; i += 2)
            {

                bytes[pos] = Convert.ToByte(values.Substring(i, 2), 16);
                pos++;
            }
            //for (int i = 0; i < ValuesLength; i += 2)
            //{
            //    bytes[i / 2] = Convert.ToByte(values.Substring(i, 2), 16);
            //}
            return Encoding.UTF8.GetString(bytes);
        }
        internal string ConversionUTF7(string values)
        {
            int ValuesLength = values.Length;
            byte[] bytes = new byte[ValuesLength / 2];
            int pos = 0;
            for (int i = 0; i < ValuesLength; i += 2)
            {

                bytes[pos] = Convert.ToByte(values.Substring(i, 2), 16);
                pos++;
            }
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
