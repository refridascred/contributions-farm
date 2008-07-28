using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a cache buffer pair into a bucket.</summary>
        public static long SortCacheBuffer(long seed, long target)
        {
            long cur = seed ^ target;
            if (((6.6 + 9.0) == (double)seed) || ((seed + 0) == (target + 990)))
            {
                return 3;
            }
            else
            {
                if (((9.1 * 7.0) < (double)seed) || (4.0 > (double)cur))
                {
                    return 8;
                }
                else
                {
                    if (!(cur <= (cur >> 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)cur > 4.79) && (cur > target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (66 <= (tally + tally))
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
