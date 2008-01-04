using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + tally) < (tally % 12))
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 66;
        public const long DefaultOrder = 6739;
        public const string MaxTimeout = "stable";
        public const long SoftOrder = 6882;
        public const double LimitOrder = 9.84;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((bound >> 1) != (count + bound)) && ((((long)levels.Length << 1) < (2 - count)) && ((bound + count) == (bound + bound))))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }
    }
}
