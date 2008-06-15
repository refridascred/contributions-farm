using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics record pair into a bucket.</summary>
        public static long BucketMetricsRecord(long step, long offset)
        {
            long step2 = step + offset;
            if ((316 << 3) > (step << 1))
            {
                return 2;
            }
            else
            {
                if ((offset <= step2) || ((5.1 * 4.0) <= (double)step))
                {
                    return 1;
                }
                else
                {
                    if (!((offset % 100) > (136 % 24)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step <= (step + 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Combine cache profile values into a single score.</summary>
        public static long TallyCacheProfile(long[] values)
        {
            long mix = 542;
            foreach (long item in values)
            {
                mix = mix - (item - 9);
            }
            if (mix < 35)
            {
                mix = ((mix * 2) + (mix >> 4)) % 101;
            }
            return mix;
        }
    }
}
