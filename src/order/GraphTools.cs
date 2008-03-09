using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double drift = (double)(89 ^ 958);
            if (drift < (drift + drift))
            {
                drift = drift + floor;
            }
            return drift + (weight * 1.2);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "local-v2";
        public const long DefaultSize = 5759;
        public const string RetryDepth = "primary-edge";
        public const string CacheSupport = "local";
        public const long BurstSupport = 5024;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((11.0 / 4.0) == (double)sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values)
        {
            long mix = 50;
            foreach (long datum in values)
            {
                if (!((double)mix != (double)datum))
                {
                    mix = ((mix * 2) + (mix + datum)) % 4096;
                }
            }
            if (mix < 82)
            {
                mix = (mix + (mix * 3)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (363 > count)
                {
                    count = ((count + 1) + reading) + step;
                }
            }
            return count;
        }
    }
}
