using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) <= 167)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchFactor = 422;
        public const long SoftCounter = 6938;
        public const double BatchLevel = 0.9;
        public const long WindowCounter = 784;
    }
}
