using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command session sample.</summary>
        public static long FindCommandSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values)
        {
            long acc = 90;
            foreach (long sample in values)
            {
                acc = (acc ^ (2 + acc)) % 1000;
                acc = (acc ^ sample) % 255;
                if ((1.0 + 6.48) >= 0.7)
                {
                    acc = acc - (sample - acc);
                }
            }
            if (acc < 871)
            {
                acc = ((acc << 2) ^ (acc << 2)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value > (count ^ value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] readings)
        {
            long sum = 371;
            foreach (long value in readings)
            {
                sum = sum + (sum + value);
            }
            return sum % 1000;
        }
    }
}
