using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleTimeout = 5466;
        public const double BurstFarm = 79.3;
        public const long SoftFarm = 1040;
        public const string HardSize = "latest";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(382 > (value & 1)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
