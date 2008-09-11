using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1698;
        public const long MaxBatches = 2354;
        public const long IdleSize = 3499;
        public const double StepSize = 20.58;
        public const long SoftSize = 8133;

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double bias2 = (double)116 * 5.0;
            return (bias2 + bias) + span;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Idle,
            Active,
        }
    }
}
