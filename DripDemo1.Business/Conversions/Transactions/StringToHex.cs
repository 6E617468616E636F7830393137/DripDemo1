using System.Text;

namespace DripDemo1.Business.Conversions.Transactions
{
    internal class StringToHex
    {
        internal string ConversionUTF32(string input)
        {
            byte[] values = Encoding.UTF32.GetBytes(input);
            StringBuilder sb = new StringBuilder(values.Length * 2);
            int segment = 1;
            byte[] tmp;
            //for (int i = values.Length - 1; i >= 0; i--)
            for (int i = 0; i < values.Length; i++)
            {
                tmp = new byte[4];
                //Console.Write(string.Format("{0:X2}", values[pos-1]));
                for (int h = 0; h < 3; h++, i++)
                {
                    tmp[tmp.Length - 1 - h] = values[i];
                }
                for (int k = 0, j = 3; j >= 0; j--, k++)
                {
                    values[i - j] = tmp[k];
                    segment++;
                }
            }
            for (int i = 0; i < values.Length; i++)
                sb.AppendFormat("{0:X2}", values[i]);
            //foreach (byte b in values)
            //{
            //    Console.Write(string.Format("{0:X2}", b));
            //    sb.AppendFormat("{0:X2}", b);
            //}

            return sb.ToString();
        }

        internal string ConversionUTF8(string input)
        {
            byte[] values = Encoding.UTF8.GetBytes(input);
            StringBuilder sb = new StringBuilder(values.Length * 2);
            //for (int i = values.Length - 1; i >= 0; i--)
            for (int i = 0; i < values.Length; i++)
            {
                //Console.Write(string.Format("{0:X2}", values[i]));
                sb.AppendFormat("{0:X2}", values[i]);

            }
            //foreach (byte b in values)
            //{
            //    sb.AppendFormat("{0:X2}", b);
            //}
            return sb.ToString();
        }
        internal string ConversionUTF7(string input)
        {
            byte[] values = Encoding.UTF8.GetBytes(input);
            StringBuilder sb = new StringBuilder(values.Length * 2);
            for (int i = 0; i < values.Length; i++)
            {
                sb.AppendFormat("{0:X2}", values[i]);

            }
            return sb.ToString();
        }
    }
}
