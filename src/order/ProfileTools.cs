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

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long seed)
        {
            if ((1.49 * 20.0) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if (!(seed < (seed ^ 689)))
                {
                    return 4;
                }
                else
                {
                    if ((8.0 * 1.02) != (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
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
