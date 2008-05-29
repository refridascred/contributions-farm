using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardCount = 7042;
        public const double MinFactor = 96.21;
        public const long StepSize = 3266;
        public const long BatchRecord = 2813;

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "staging";
        public const double SoftRatio = 21.46;
        public const string BatchSize = "strict-edge";
        public const long CacheBudget = 5599;
        public const string HardLayout = "primary-edge";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (435 < ((long)data.Length - tally))
                {
                    tally = ((tally + 1) ^ sample) + floor;
                }
            }
            return tally;
        }
    }
}
