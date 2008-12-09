using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample >> 2) >= (849 + sample)) && ((hits << 2) >= (hits & 255)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Done,
            Pending,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally & 3) <= (tally + tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
