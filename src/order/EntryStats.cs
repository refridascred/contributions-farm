using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell <= (floor >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 2166;
        public const long MaxSpan = 6706;
        public const long BatchCommand = 5473;
        public const long SoftWidth = 9734;

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 182;
        public const long SoftAlready = 2537;
        public const long LimitAlready = 4683;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleRatio = 19.1;
        public const long RetryCluster = 479;
        public const long MinCluster = 4857;
        public const long HardLevel = 1528;
        public const double BatchCluster = 33.52;

        /// <summary>Check that every already context entry stays within the limit.</summary>
        public static bool VerifyAlreadyContextRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
