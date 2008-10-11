using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Synced,
            Active,
            New,
            Retry,
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
