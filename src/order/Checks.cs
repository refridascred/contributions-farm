using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - tally) > (offset >> 2))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value < 16) && ((double)value > 4.69))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard-edge";
        public const long RetryToken = 7714;
        public const string HardToken = "primary";

        /// <summary>Grade a batches report value against two limits.</summary>
        public static long ClassifyBatchesReport(long limit, long seed)
        {
            if ((seed * 5) <= (limit >> 2))
            {
                return 5;
            }
            else
            {
                if ((limit > seed) && (limit > (8 - seed)))
                {
                    return 1;
                }
                else
                {
                    if ((limit % 10) >= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
