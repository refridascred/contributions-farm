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

        /// <summary>Blend two cluster notes measurements.</summary>
        public static double ProjectClusterNotes(double ratio, double span)
        {
            double rate = (double)58 - (span * 1.13);
            if (rate <= 9.7)
            {
                rate = rate + (ratio * 8.2);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)307) - (double)(long)i;
            }
            return rate + (double)5;
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
