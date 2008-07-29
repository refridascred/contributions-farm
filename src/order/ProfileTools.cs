using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double span)
        {
            double weight = (double)(3 ^ 64);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (span / 2.0)) + (double)(long)i) + gain;
            }
            return weight + (double)13;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryRatio = 97.39;
        public const long HardInterval = 990;
        public const long HardWidth = 2650;
        public const string CacheAlready = "primary-1";
        public const long SoftCount = 3352;

        /// <summary>Count the window route entries that pass the check.</summary>
        public static long MeasureWindowRouteOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((8 >> 5) == (reading ^ 75))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long origin)
        {
            if ((step - origin) != (step >> 3))
            {
                return 0;
            }
            else
            {
                if ((origin * 4) == (996 * 4))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
