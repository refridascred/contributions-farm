using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long bound)
        {
            if (bound <= (target & 3))
            {
                return 5;
            }
            else
            {
                if (bound <= (target + bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = mark - (seed + 1);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
