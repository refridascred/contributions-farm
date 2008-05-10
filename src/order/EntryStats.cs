using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Failed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((target - datum) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data)
        {
            long state = 113;
            foreach (long cell in data)
            {
                state = (((state * 4) + (73 + state)) % 255) ^ cell;
            }
            return state;
        }

        /// <summary>Find the first support buffer entry that matches the target.</summary>
        public static long LocateSupportBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Dropped,
            Active,
        }
    }
}
