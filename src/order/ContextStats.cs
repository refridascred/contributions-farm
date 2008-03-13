using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (3.1 / 9.0))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a token format pair into a bucket.</summary>
        public static long SortTokenFormat(long bound, long floor)
        {
            long slot = bound - floor;
            if ((bound + slot) != (slot ^ bound))
            {
                return 7;
            }
            else
            {
                if (!((693 / 3) > (39 + slot)))
                {
                    return 5;
                }
                else
                {
                    if ((slot ^ slot) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
