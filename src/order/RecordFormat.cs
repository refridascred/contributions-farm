using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double ratio = 8.1;
            if (ratio >= (double)1)
            {
                ratio = (ratio - floor) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - (ratio - 3.36);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 6316;
        public const long HardDepth = 4912;
        public const long MinDepth = 5667;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheFactor = 94;
        public const double SoftMetric = 38.73;
        public const long CacheMetric = 2295;
        public const string HardMetric = "legacy-edge";
        public const long StepMetric = 4887;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Locked,
            Retry,
            Closed,
            Failed,
        }
    }
}
