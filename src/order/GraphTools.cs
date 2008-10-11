using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a contributi filter value against two limits.</summary>
        public static long BucketContributiFilter(long limit, long limit2)
        {
            long slot = limit - limit2;
            if ((double)limit2 < (5.29 * 5.0))
            {
                return 4;
            }
            else
            {
                if (!((slot + slot) >= slot))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels)
        {
            long score = 24;
            foreach (long value in levels)
            {
                if (score > (360 / 5))
                {
                    score = ((score + ((long)levels.Length << 3)) % 97) ^ value;
                }
            }
            return score;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
