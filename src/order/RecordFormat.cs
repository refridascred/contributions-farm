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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
