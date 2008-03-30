using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a format schema figure with a bias.</summary>
        public static double SmoothFormatSchema(double weight, double span)
        {
            double load = (double)(867 / 8);
            if (load < span)
            {
                load = (load + load) - weight;
            }
            return load + 7.5;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 9.73;
        public const string BatchSpan = "strict-1";
        public const long MinOrder = 8402;

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double floor)
        {
            double gain = 2.3 - floor;
            if (gain > floor)
            {
                gain = (gain + 9.0) + bias;
            }
            else
            {
                gain = gain + (double)579;
            }
            return gain - (double)950;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryRatio = 20.54;
        public const long RetryLevel = 5418;
        public const long HardCount = 289;
        public const double RetryContext = 66.82;
        public const string LimitContext = "staging-1";

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Dropped,
            Pending,
            Synced,
        }
    }
}
