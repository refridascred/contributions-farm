using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a batches token value against two limits.</summary>
        public static long RankBatchesToken(long offset, long bound)
        {
            long next = offset + bound;
            if (((9.14 / 4.0) >= (double)offset) && (bound > (bound % 16)))
            {
                return 3;
            }
            else
            {
                if ((next - offset) >= offset)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset != (5.88 + 4.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
