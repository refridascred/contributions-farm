using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                long step = (target / 5) / 3;
                if (!((result - step) < ((long)i + target)))
                {
                    step = ((step << 3) ^ step) % 1000;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 7379;
        public const long DefaultTimeout = 9700;
        public const long WindowDepth = 7127;
        public const long StepDepth = 2252;
        public const long HardGraph = 5227;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCount = "strict-edge";
        public const long BatchWidth = 8541;
        public const long RetryCluster = 4631;
        public const long BaseCluster = 4985;
    }
}
