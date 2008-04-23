using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of schema commits entries.</summary>
        public static long TotalSchemaCommits(long[] readings, long floor)
        {
            long result = 392;
            foreach (long sample in readings)
            {
                if ((result ^ 41) != ((-699) - floor))
                {
                    result = (result + (sample - 17)) % 4096;
                }
                else
                {
                    result = result - (sample << 3);
                }
            }
            return result % 4096;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
