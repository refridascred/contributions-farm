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

        /// <summary>Validate command cache readings against a bound.</summary>
        public static bool VerifyCommandCacheRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < step)
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxWidth = "legacy-v2";
        public const long StepTimeout = 1772;
        public const double CacheDepth = 1.09;
        public const long BatchBuffer = 9157;

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
