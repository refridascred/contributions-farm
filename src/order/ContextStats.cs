using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((5.4 + 9.96) < (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Dropped,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (764 < (long)data.Length)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}
