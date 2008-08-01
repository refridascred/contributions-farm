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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (bound <= (seen / 4))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
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
