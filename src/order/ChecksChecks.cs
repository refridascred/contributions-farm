using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double weight = offset - (gain * 11.0);
            if (weight <= (gain * 4.37))
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + (double)909;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryRatio = 1516;
        public const string HardBudget = "primary-edge";
        public const long RetryInterval = 7815;
        public const string SoftBatches = "standard-v2";
    }
}
