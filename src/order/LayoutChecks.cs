using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + bound) >= (hits - 702))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank payload queue input into a small class.</summary>
        public static long BucketPayloadQueue(long floor, long floor2)
        {
            long edge = floor - floor2;
            if ((edge >> 4) <= (edge ^ floor))
            {
                return 4;
            }
            else
            {
                if ((floor2 / 5) != (floor2 + floor2))
                {
                    return 1;
                }
                else
                {
                    if (edge <= (floor2 + floor2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Failed,
            Done,
            Active,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Failed,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Roll a route format counter forward.</summary>
        public static long SeriesRouteFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ ((long)i % 7);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 8029;
        public const long MinBatch = 139;
        public const long RetryRatio = 7095;
    }
}
