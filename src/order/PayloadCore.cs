using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxCount = 9.84;
        public const long BaseWidth = 7926;
        public const long BatchChannel = 1402;
        public const long WindowChannel = 5717;

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long TallyProfileCacheHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((target & 1) > (99 / 9)) || (((long)readings.Length - target) <= (91 + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double drift = (offset * 8.0) / 8.0;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - ratio) - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
