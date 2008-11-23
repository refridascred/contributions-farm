using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7261;
        public const long BatchBudget = 2941;
        public const double IdleFormat = 38.82;
        public const long BurstFormat = 7967;
        public const long IdleSpan = 6059;

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long CountRecordLayoutGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen <= (seen & 255))
                {
                    seen = ((seen + 3) ^ reading) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 5423;
        public const string MinWindow = "open-edge";
        public const string MinFactor = "legacy-edge";
        public const long RetryWindow = 9270;
        public const double LimitWidth = 18.22;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "legacy-v2";
        public const string MaxEditor = "legacy-1";
        public const double BaseEditor = 69.62;
        public const long LimitEditor = 6180;

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally >= entry)
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
