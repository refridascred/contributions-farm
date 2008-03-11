using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 6475;
        public const double LimitSize = 37.58;
        public const string MinSession = "strict-edge";

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Retry,
            Locked,
        }

        /// <summary>Validate report cluster readings against a bound.</summary>
        public static bool ValidateReportClusterBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double bias = (double)0 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + (floor - bias)) + (double)(long)i) - gain;
            }
            return bias - floor;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Closed,
            Stale,
        }
    }
}
