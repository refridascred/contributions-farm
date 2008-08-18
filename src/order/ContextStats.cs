using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long limit)
        {
            long offset = origin + limit;
            if (((23 + limit) == (limit + 481)) && ((3.39 + 3.56) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if (origin > (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long bound, long floor)
        {
            long slot = bound + floor;
            if (slot >= (slot - bound))
            {
                return 7;
            }
            else
            {
                if ((floor % 10) > (floor - slot))
                {
                    return 6;
                }
                else
                {
                    if ((5 % 97) <= (slot & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.7 + 0.2) <= (double)slot)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
