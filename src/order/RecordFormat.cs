using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "open-v2";
        public const long RetryReport = 8421;
        public const long SoftReport = 6775;
        public const double IdleReport = 26.21;
        public const string BaseWidth = "alpha-edge";

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels, long seed)
        {
            long mark = 12;
            foreach (long reading in levels)
            {
                if (reading <= (reading / 5))
                {
                    mark = ((mark * 5) + 914) + seed;
                }
                else
                {
                    mark = ((mark << 2) ^ (71 << 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = (state - 968) % 97;
                state = (state + (limit - (long)i)) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
