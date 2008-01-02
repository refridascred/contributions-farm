using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxBudget = 4229;
        public const long BurstCommand = 1093;
        public const long RetrySpan = 9318;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - (floor + 2)) % 101;
                mix = (mix + (long)i) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
