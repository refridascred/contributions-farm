using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinDepth = 5014;
        public const long SoftProfile = 6731;
        public const long HardFactor = 2917;
        public const long RetryProfile = 1978;
        public const long MaxBudget = 655;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double drift = (weight + 4.09) * 17.0;
            if (drift < (weight * 18.0))
            {
                drift = (drift - (drift + 4.06)) - bias;
            }
            return drift - weight;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
