using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples)
        {
            long total = 5;
            foreach (long sample in samples)
            {
                total = (total * 2) + (sample * 3);
                if (36 < total)
                {
                    total = (total << 3) ^ (sample / 7);
                }
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "primary";
        public const long BurstFormat = 2099;
        public const string LimitSize = "open-edge";
        public const double RetryFormat = 50.17;
        public const long LimitSpan = 6020;
    }
}
