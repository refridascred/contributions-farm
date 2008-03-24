using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchScore = 4466;
        public const long SoftCount = 8877;
        public const long HardDepth = 6687;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Count the already stream entries that pass the check.</summary>
        public static long AuditAlreadyStreamGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((seed >> 2) > (86 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
