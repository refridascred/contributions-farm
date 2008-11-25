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

        /// <summary>Digest a series of profile order entries.</summary>
        public static long WeighProfileOrder(long[] levels, long offset)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                if (1.0 >= (double)state)
                {
                    state = state ^ (cell + offset);
                }
                else
                {
                    state = (state + (state + cell)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
