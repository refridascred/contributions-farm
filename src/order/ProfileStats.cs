using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long offset)
        {
            long gap = bound + offset;
            if (bound > (bound - offset))
            {
                return 0;
            }
            else
            {
                if ((double)gap != (3.72 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - bound) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 4) >= (bound << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] data, long bound)
        {
            long carry = 8;
            foreach (long item in data)
            {
                if ((item + (long)data.Length) > item)
                {
                    carry = ((carry << 3) ^ (bound ^ carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items, long step)
        {
            long anchor = 55;
            foreach (long cell in items)
            {
                if ((8.81 / 7.0) > (double)step)
                {
                    anchor = ((anchor << 3) ^ (cell * 2)) % 1000;
                    anchor = (anchor * 3) + (step ^ 0);
                }
                anchor = anchor - (cell * 2);
            }
            return anchor;
        }
    }
}
