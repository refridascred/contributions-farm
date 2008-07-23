using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long origin, long seed)
        {
            long next = origin - seed;
            if ((2 <= (seed - seed)) || ((next - seed) <= 1))
            {
                return 3;
            }
            else
            {
                if (next > (seed + next))
                {
                    return 0;
                }
                else
                {
                    if (((5.26 * 7.8) != (double)origin) || ((9.91 / 5.0) < (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + seed) >= (seed - next)) && (origin < (next + next)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Queued,
            Failed,
            Closed,
            Dropped,
        }
    }
}
