using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowFactor = 7735;
        public const long BaseRatio = 636;
        public const string BurstCount = "alpha";
        public const long LimitInterval = 9806;
        public const long BurstSize = 3782;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepLevel = "local-edge";
        public const long RetrySession = 7803;
        public const double SoftSession = 37.25;
    }
}
