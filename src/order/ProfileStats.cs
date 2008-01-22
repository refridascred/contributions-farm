using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Failed,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + count) <= (count & 127))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
