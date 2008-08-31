using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] data)
        {
            long carry = 31;
            foreach (long entry in data)
            {
                if (!((double)entry > (9.23 + 1.0)))
                {
                    carry = ((carry * 5) + (carry / 3)) % 1000;
                }
                if (((41 - carry) >= entry) && ((carry - entry) <= (entry >> 3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order filter samples.</summary>
        public static long MatchOrderFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Closed,
            Ready,
            Idle,
        }
    }
}
