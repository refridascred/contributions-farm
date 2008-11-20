using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count cluster entry pairs that satisfy a relation.</summary>
        public static long MatchClusterEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            New,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels, long seed)
        {
            long carry = 14;
            foreach (long value in levels)
            {
                carry = (carry + value) % 101;
            }
            if (carry < 521)
            {
                carry = carry + (seed - seed);
            }
            return carry;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings)
        {
            long score = 9;
            foreach (long value in readings)
            {
                if (!((45 + score) >= (value * 5)))
                {
                    score = (score ^ score) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (value ^ 449)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] series)
        {
            long result = 899;
            foreach (long item in series)
            {
                result = (((result << 3) ^ 2) % 4096) - item;
            }
            return result % 65521;
        }
    }
}
