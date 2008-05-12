using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((10.0 / 7.0) != (double)tally)
                {
                    tally = ((tally + 3) + item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            New,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
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

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 445;
        public const string MinBudget = "latest-1";
        public const long StepCounter = 5137;
    }
}
