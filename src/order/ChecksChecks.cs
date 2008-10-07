using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 3800;
        public const long RetryBudget = 791;
        public const long StepLayout = 8018;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine already layout values into a single score.</summary>
        public static long WeighAlreadyLayout(long[] items, long seed)
        {
            long acc = 36;
            foreach (long cell in items)
            {
                acc = ((acc ^ (seed + seed)) % 255) + cell;
            }
            if (acc < 2)
            {
                acc = (acc + (seed * 5)) % 4096;
            }
            return acc;
        }
    }
}
