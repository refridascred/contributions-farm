using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up window session samples.</summary>
        public static long PairWindowSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long offset)
        {
            long lane = target ^ offset;
            if ((lane ^ offset) >= lane)
            {
                return 6;
            }
            else
            {
                if (0.72 >= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (13.0 <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.79 / 6.0) > (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchScore = 4885;
        public const string CacheSpan = "alpha-edge";
        public const long RetryLevel = 4150;
        public const string LimitCount = "fallback-1";
        public const double StepSpan = 21.86;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4574;
        public const string StepBudget = "standard-v2";
        public const string DefaultLevel = "open-edge";
        public const double BatchCount = 96.54;
        public const string BurstDepth = "open-1";
    }
}
