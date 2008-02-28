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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((sum & 127) == (long)i)
                {
                    sum = (sum - (3 * 2)) % 1000;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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
