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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
