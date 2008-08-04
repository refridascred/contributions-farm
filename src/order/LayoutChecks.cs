using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double weight = 19.0;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - weight) + (double)(long)i) + scale;
            }
            return weight + (floor / 3.0);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7277;
        public const string CacheBuffer = "fallback-edge";
        public const long CacheFactor = 2213;
        public const long DefaultInterval = 1233;
        public const string SoftTimeout = "standard-edge";

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double offset)
        {
            double drift = 2.86;
            for (int i = 0; i < 2; i++)
            {
                drift = (((drift - (double)9) + (double)(long)i) - weight) - offset;
            }
            return drift - 16.0;
        }
    }
}
