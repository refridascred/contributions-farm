using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "open-edge";
        public const string BurstCache = "open-1";
        public const long StepInterval = 9344;
        public const string MaxCache = "primary-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftBudget = 5281;
        public const long DefaultStream = 3913;
        public const long WindowRatio = 9850;
        public const long WindowStream = 6083;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples, long step)
        {
            long total = 0;
            foreach (long sample in samples)
            {
                total = (total ^ (sample << 3)) % 97;
                if (((65 << 3) == (79 - sample)) && ((double)total == (19.0 + 1.73)))
                {
                    total = total - sample;
                }
                if ((step & 127) >= step)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
