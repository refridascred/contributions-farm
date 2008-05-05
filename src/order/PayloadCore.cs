using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) >= 759)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                if ((value & 31) > (965 ^ 139))
                {
                    sum = (sum - value) % 65521;
                }
                if ((double)sum > (double)(-4))
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            if (sum > 729)
            {
                sum = sum - (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
