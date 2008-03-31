using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum >= hits)
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 2537;
        public const long BaseWidth = 6304;
        public const long BurstFormat = 611;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Paused,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long seed)
        {
            if (((double)floor == (18.0 + 10.0)) || ((floor + seed) > floor))
            {
                return 7;
            }
            else
            {
                if ((598 - floor) > (floor / 4))
                {
                    return 8;
                }
                else
                {
                    if (seed >= (seed & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor * 2) >= (seed - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
