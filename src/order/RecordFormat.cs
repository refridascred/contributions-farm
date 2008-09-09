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
        public const double HardOrder = 11.86;
        public const string IdleBudget = "standard-edge";
        public const long MaxOrder = 5377;
        public const double BatchSpan = 83.01;
        public const long CacheSpan = 1174;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Retry,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = acc + (2 - 210);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
