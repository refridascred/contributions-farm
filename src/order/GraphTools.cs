using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(18.0 >= (double)step) && ((926 << 1) < (step + 2)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "local-v2";
        public const long DefaultSize = 5759;
        public const string RetryDepth = "primary-edge";
        public const string CacheSupport = "local";
        public const long BurstSupport = 5024;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Rank entry githubfarm input into a small class.</summary>
        public static long BucketEntryGithubfarm(long offset, long seed)
        {
            if (((seed + 516) < ((-2) ^ seed)) || ((10.0 - 5.0) >= (double)seed))
            {
                return 1;
            }
            else
            {
                if (6.21 < (double)2)
                {
                    return 4;
                }
                else
                {
                    if (((seed << 1) == (seed + 459)) || ((double)seed >= (6.43 - 1.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(item <= ((-7) % 60)))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
