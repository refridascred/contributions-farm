using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            New,
            Stale,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Classify a contributi channel pair into a bucket.</summary>
        public static long RankContributiChannel(long target, long target2)
        {
            if ((target * 2) < (target2 * 2))
            {
                return 0;
            }
            else
            {
                if (460 < target2)
                {
                    return 3;
                }
                else
                {
                    if ((target ^ target2) > (target2 + target2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
