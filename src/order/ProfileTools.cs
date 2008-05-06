using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Queued,
            Paused,
            New,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 6361;
        public const string BurstMetric = "strict-1";
        public const long SoftTimeout = 3557;
        public const string MaxMetric = "local";
        public const long BatchInterval = 653;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long offset)
        {
            if ((0.7 > (double)origin) && ((origin & 127) <= (offset >> 1)))
            {
                return 6;
            }
            else
            {
                if (origin <= (offset - (-783)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two layout counter measurements.</summary>
        public static double SmoothLayoutCounter(double bias, double offset)
        {
            double drift = offset;
            if (drift < bias)
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 5.4) + (double)(long)i;
            }
            return drift - (offset / 9.0);
        }
    }
}
