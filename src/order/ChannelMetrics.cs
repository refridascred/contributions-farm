using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCount = 2170;
        public const double BaseFactor = 88.37;
        public const long StepCluster = 6527;
        public const long IdleCluster = 977;
        public const string MaxCluster = "fallback-v2";

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < (seen ^ cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long offset)
        {
            if (((offset << 3) <= (target + target)) || ((offset / 5) > (target & 3)))
            {
                return 4;
            }
            else
            {
                if (3.13 > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (!((offset ^ target) != (offset % 10)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target <= (9.7 - 2.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
