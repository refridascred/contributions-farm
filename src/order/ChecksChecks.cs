using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryBudget = 4886;
        public const long BatchInterval = 8003;
        public const long HardWindow = 8641;
        public const long StepBudget = 3435;
        public const string SoftBudget = "local-edge";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if (!((origin >> 1) != (origin + mark)))
                {
                    mark = (mark ^ (origin + 600)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
