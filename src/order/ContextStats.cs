using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a farm cluster reading.</summary>
        public static double ProjectFarmCluster(double rate, double offset)
        {
            double scale = 0.34;
            if (scale >= rate)
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (rate / 5.0)) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Closed,
            New,
            Idle,
            Stale,
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double floor)
        {
            double scale = (double)(9 ^ 2);
            if (scale >= (scale - scale))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor - bias)) + (double)(long)i;
            }
            return scale - (double)83;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 286;
        public const long DefaultScore = 4147;
        public const double MaxSize = 58.26;
        public const long SoftDepth = 1284;
    }
}
