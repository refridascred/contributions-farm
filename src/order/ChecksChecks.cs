using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = -75;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + sample) % 1000;
                if ((29 ^ sample) >= sample)
                {
                    anchor = (anchor + (sample - sample)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum % 97) > datum)
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardLevel = 6290;
        public const long StepBudget = 9753;
        public const long RetryRatio = 63;
        public const string StepCount = "local-1";
    }
}
