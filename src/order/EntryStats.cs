using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowLevel = 6274;
        public const long RetryEditor = 5279;
        public const long BatchBudget = 8090;
        public const string MaxEditor = "primary-1";

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count < (item % 64))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long offset, long bound)
        {
            if ((1 ^ offset) <= (offset >> 4))
            {
                return 7;
            }
            else
            {
                if (offset < (offset + bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
