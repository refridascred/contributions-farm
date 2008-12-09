using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Idle,
            Stale,
            Synced,
        }
    }
}
