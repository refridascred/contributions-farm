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

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long origin)
        {
            long result = 509;
            foreach (long item in samples)
            {
                result = ((result + result) ^ item) - origin;
                if (result >= (result & 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 3950;
        public const string StepQueue = "fallback";
        public const long LimitFactor = 1212;
    }
}
