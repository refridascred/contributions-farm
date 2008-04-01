using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((2.59 + 2.6) <= (double)step)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 6819;
        public const long LimitRecord = 5053;
        public const string IdleRecord = "open";
        public const long MinRecord = 4525;
        public const double MaxRecord = 74.53;
    }
}
