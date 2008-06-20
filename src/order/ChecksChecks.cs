using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a graph account counter forward.</summary>
        public static long SeriesGraphAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + result) - (long)i2;
                }
                if (!((double)origin > (9.0 * 11.0)))
                {
                    result = ((result << 2) ^ (result + result)) % 1000;
                }
                else
                {
                    result = (result + (origin % 16)) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
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
