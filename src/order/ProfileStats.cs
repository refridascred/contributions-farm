using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Ready,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 8.9;
        public const string RetryReport = "local";
        public const string BaseLevel = "strict-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 377;
        public const long LimitSize = 152;
        public const double StepCount = 28.03;
    }
}
