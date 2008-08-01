using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a token layout pair into a bucket.</summary>
        public static long RankTokenLayout(long limit, long seed)
        {
            if ((double)seed != (1.2 - 19.0))
            {
                return 5;
            }
            else
            {
                if ((seed + 12) == (0 + seed))
                {
                    return 1;
                }
                else
                {
                    if (limit >= (-201))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((floor * 2) >= cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Done,
            Idle,
        }
    }
}
