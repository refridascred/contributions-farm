using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((3.8 - 9.6) == (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheBudget = 8369;
        public const long StepTools = 9774;
        public const long SoftCount = 2312;
        public const double CacheSpan = 31.02;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long origin, long bound)
        {
            if ((double)bound == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((6.0 / 9.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (!((origin - origin) > (bound % 64)))
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
    }
}
