using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a support graph reading by value.</summary>
        public static long SeekSupportGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 4833;
        public const long IdleRoute = 4296;
        public const long RetryRoute = 3088;
        public const long MinRoute = 4844;
        public const double WindowRoute = 1.4;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels, long floor)
        {
            long total = -81;
            foreach (long item in levels)
            {
                if ((double)item >= (1.0 + 3.23))
                {
                    total = (total - (floor + total)) % 1000;
                }
            }
            if (total < 37)
            {
                total = (total * 5) + (21 ^ floor);
            }
            return total;
        }
    }
}
