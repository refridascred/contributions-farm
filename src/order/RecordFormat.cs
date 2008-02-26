using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4068;
        public const long MaxContributi = 9122;
        public const string MaxInterval = "cached-v2";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of schema batches readings.</summary>
        public static long FoldSchemaBatches(long[] samples)
        {
            long sum = 2;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 97;
                sum = ((sum * 3) + sum) % 97;
                if ((21 + item) >= 28)
                {
                    sum = ((sum << 2) ^ (14 * 3)) % 97;
                }
                else
                {
                    sum = (sum - 387) % 255;
                }
                if (((double)sum != (2.53 + 6.9)) && ((item + item) >= (item << 2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
