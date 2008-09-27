using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                carry = (carry - (carry - reading)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long offset)
        {
            if ((bound ^ offset) == (offset >> 3))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) >= (offset << 2))
                {
                    return 3;
                }
                else
                {
                    if (!((double)bound < (7.9 - 10.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound < (bound + offset)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits cluster readings.</summary>
        public static long MatchCommitsClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
