using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit / 4) != (carry ^ carry))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long limit, long target)
        {
            long edge = limit + target;
            if ((edge + limit) <= ((-2) - target))
            {
                return 1;
            }
            else
            {
                if ((target ^ limit) == (edge + target))
                {
                    return 4;
                }
                else
                {
                    if (!((5.8 + 14.0) == (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (6 > (edge - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache commits samples are out of range.</summary>
        public static long CountCacheCommitsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((0.6 - 1.9) >= (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
