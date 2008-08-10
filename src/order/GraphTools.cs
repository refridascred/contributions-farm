using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double floor)
        {
            double scale = (floor / 9.0) / 8.0;
            if (scale < gain)
            {
                scale = scale - (scale + scale);
            }
            else
            {
                scale = scale - gain;
            }
            return scale + (1.53 + scale);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitFactor = "local-1";
        public const double MinAccount = 50.98;
        public const string StepTimeout = "alpha-edge";
        public const double DefaultScore = 0.85;
        public const long BaseSpan = 2464;
    }
}
