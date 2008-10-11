using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long score = 261;
            foreach (long reading in values)
            {
                if ((seed ^ reading) > (seed / 4))
                {
                    score = (score << 2) ^ (4 + seed);
                }
                else
                {
                    score = score - reading;
                }
            }
            return score;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Draft,
            Active,
            Done,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long offset, long limit)
        {
            long next = offset + limit;
            if ((offset * 3) <= next)
            {
                return 4;
            }
            else
            {
                if ((3 + next) <= (next ^ next))
                {
                    return 5;
                }
                else
                {
                    if (!((5.0 / 5.0) == (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
