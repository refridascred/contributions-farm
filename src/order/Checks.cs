using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 30.63;
        public const string WindowFactor = "alpha";
        public const double LimitContributi = 33.0;

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double gain = (double)(97 * 4);
            if (gain <= (double)43)
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + (gain + floor);
            }
            return gain - (ratio + gain);
        }

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long CountSupportTokenHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (bound < 441)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 3950;
        public const string StepQueue = "fallback";
        public const long LimitFactor = 1212;
    }
}
