using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long next = step + seed;
            if (((double)next >= (3.02 * 8.76)) || ((seed + seed) >= step))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 8.22) != (double)next)
                {
                    return 2;
                }
                else
                {
                    if (next <= (3 + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long target)
        {
            long total = 452;
            foreach (long reading in data)
            {
                total = (total * 4) + (target ^ reading);
                if ((double)total < (double)reading)
                {
                    total = (total + (total - reading)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Failed,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin <= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
