using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchDepth = "primary-v2";
        public const double MinBatch = 16.23;
        public const string BurstBatch = "primary";
        public const long BurstSize = 1615;
        public const double BaseBatch = 8.97;

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double bias2 = (double)116 * 5.0;
            return (bias2 + bias) + span;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "legacy-v2";
        public const long StepCommand = 7164;
        public const long LimitCommand = 1558;
        public const long MaxCommand = 9566;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Idle,
            Active,
        }
    }
}
