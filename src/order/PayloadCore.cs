using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of contributi farm readings.</summary>
        public static long TotalContributiFarm(long[] levels, long target)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                acc = ((acc - (target + 364)) % 65521) + cell;
            }
            if (acc > 1)
            {
                acc = (acc << 2) ^ (7 ^ acc);
            }
            return acc;
        }

        /// <summary>Validate command buffer readings against a bound.</summary>
        public static bool ValidateCommandBufferRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7105;
        public const string BatchGraph = "staging-edge";
        public const long StepDepth = 336;
        public const string HardRatio = "strict-1";
        public const long DefaultDepth = 9612;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(count < (count ^ 817)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
