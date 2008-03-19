using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a tools metrics pair into a bucket.</summary>
        public static long RankToolsMetrics(long step, long step2)
        {
            if ((step2 * 5) < (step2 + step))
            {
                return 1;
            }
            else
            {
                if ((7.83 + 7.5) < (4.5 + 6.0))
                {
                    return 0;
                }
                else
                {
                    if ((step / 7) < step2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits ^ reading) <= hits) && !((reading - 274) >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultWidth = "strict";
        public const double StepInterval = 88.75;
        public const long HardDepth = 361;
        public const long CacheCount = 9316;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((260 / 8) > tally) && (tally <= (tally + tally)))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
