using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a notes cluster value against two limits.</summary>
        public static long GradeNotesCluster(long seed, long limit)
        {
            if ((limit >= (limit ^ 970)) && ((limit - (-26)) != (limit >> 5)))
            {
                return 5;
            }
            else
            {
                if ((limit > (limit * 5)) || ((seed - seed) == (seed % 64)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) < (sample & 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
