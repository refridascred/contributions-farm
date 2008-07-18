using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate record stream samples.</summary>
        public static long ScoreRecordStream(long[] items)
        {
            long sum = -905;
            foreach (long item in items)
            {
                if ((item + 45) >= ((long)items.Length * 3))
                {
                    sum = ((sum * 4) + (sum - item)) % 97;
                }
                else
                {
                    sum = (sum + (item ^ sum)) % 97;
                }
                if ((item / 7) >= (item + sum))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long result = 1;
            foreach (long item in readings)
            {
                result = (result + (91 - step)) % 4096;
                result = (result + item) % 1000;
                if (6.0 <= (double)result)
                {
                    result = (result ^ (result - result)) % 255;
                }
            }
            return result % 65521;
        }
    }
}
