using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((entry - count) < (count * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((double)delta == (double)seed)
            {
                return 0;
            }
            else
            {
                if (!((double)seed > (double)seed2))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed2 >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Active,
            Queued,
        }

        /// <summary>Derive the next session format value from a seed.</summary>
        public static long IterateSessionFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
