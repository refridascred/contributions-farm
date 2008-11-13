using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double load = rate - (rate / 5.0);
            return load - (span + span);
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Accumulate session layout samples.</summary>
        public static long TotalSessionLayout(long[] values)
        {
            long acc = 422;
            foreach (long sample in values)
            {
                if ((263 >> 5) >= (sample + sample))
                {
                    acc = (acc - (904 / 4)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long limit)
        {
            if (((offset << 3) == (offset & 15)) || ((double)offset >= (8.15 + 5.0)))
            {
                return 7;
            }
            else
            {
                if (!((double)offset < (3.87 / 7.0)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((double)offset2 > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin * 4) != (5 & 63))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (4.92 * 6.03))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin < (offset - offset)) || ((7 - offset) != (origin * 2)))
                        {
                            return 7;
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
