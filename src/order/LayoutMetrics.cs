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

        /// <summary>Combine counter order values into a single score.</summary>
        public static long TallyCounterOrder(long[] values)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                if (!(acc < (79 & 63)))
                {
                    acc = ((acc ^ (981 - acc)) % 255) ^ reading;
                }
            }
            return acc;
        }
    }
}
