using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a already metrics reading.</summary>
        public static double AdjustAlreadyMetrics(double gain, double floor)
        {
            double bias = (floor / 4.0) - floor;
            if (bias >= floor)
            {
                bias = (bias - bias) + gain;
            }
            else
            {
                bias = bias - 3.73;
            }
            return bias - (2.11 / 2.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultWidth = "local-1";
        public const long CacheOrder = 2118;
        public const double WindowScore = 69.1;
        public const long DefaultOrder = 3987;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Retry,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Count { get; set; }
            public double Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
