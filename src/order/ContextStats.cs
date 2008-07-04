using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long floor)
        {
            long gap = step + floor;
            if (((12.0 / 2.0) > (double)gap) || ((double)gap < (1.0 * 8.6)))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (18.0 * 1.4))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 3) > (-197))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.8 + 6.0) <= (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
