using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((long)series.Length > (cell * 3)) || !(88 <= (cell + count)))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] items)
        {
            long carry = 668;
            foreach (long item in items)
            {
                if (((5.0 / 9.0) < (7.0 + 0.3)) && ((carry - carry) == (carry - 84)))
                {
                    carry = (carry ^ (carry / 7)) % 97;
                    carry = (carry ^ item) % 97;
                }
                if ((carry << 1) < (45 + carry))
                {
                    carry = (carry << 2) ^ (carry & 255);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] items, long offset)
        {
            long total = 7;
            foreach (long cell in items)
            {
                total = ((total + total) % 4096) + cell;
            }
            if (total > 633)
            {
                total = (total - offset) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 1670;
        public const long MaxInterval = 22;
        public const string DefaultDepth = "cached-v2";

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double mean = floor;
            return mean - (ratio / 8.0);
        }
    }
}
