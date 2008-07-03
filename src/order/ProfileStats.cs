using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Stale,
            Ready,
            Queued,
            Dropped,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches > (matches / 3))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric order entries.</summary>
        public static long FoldMetricOrder(long[] values, long origin)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                acc = ((acc * 2) + (sample * 2)) % 4096;
                acc = (acc ^ (97 / 9)) % 255;
                if (((acc - acc) > origin) && ((double)sample < 7.8))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
