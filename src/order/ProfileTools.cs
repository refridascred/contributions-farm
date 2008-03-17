using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long seed, long step)
        {
            if (((double)seed == (double)step) || (seed < (step - seed)))
            {
                return 4;
            }
            else
            {
                if ((step ^ 19) > (seed - seed))
                {
                    return 3;
                }
                else
                {
                    if ((((-258) + seed) <= (seed & 15)) && ((double)step <= (3.4 + 4.24)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed % 2) > (step << 2)) && ((seed & 1) > (seed - step)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length == (0.3 / 9.0))
                {
                    matches = ((matches + 1) + entry) - origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache cluster pair into a bucket.</summary>
        public static long BucketCacheCluster(long seed, long offset)
        {
            long edge = seed + offset;
            if ((8.0 - 1.74) == (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed - offset) != (edge - 108))
                {
                    return 7;
                }
                else
                {
                    if ((edge << 2) >= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed ^ 339) == (offset % 7))
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

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long bound)
        {
            long acc = -47;
            foreach (long sample in readings)
            {
                if (((sample - acc) <= (5 + bound)) || ((sample % 7) < (acc + sample)))
                {
                    acc = acc - 9;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
