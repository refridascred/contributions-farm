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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
