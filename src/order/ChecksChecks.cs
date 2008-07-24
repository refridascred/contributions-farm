using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryBudget = 4886;
        public const long BatchInterval = 8003;
        public const long HardWindow = 8641;
        public const long StepBudget = 3435;
        public const string SoftBudget = "local-edge";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Stale,
            Draft,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double drift = (double)9;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - 0.7) + (double)(long)i) - bias;
            }
            return drift + (7.46 + bias2);
        }
    }
}
