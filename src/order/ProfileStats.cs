using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + tally) >= value) && ((value - 15) >= (579 - tally))) && (((double)tally != (double)value) && ((double)tally <= 6.41)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long offset, long bound)
        {
            long gap = offset + bound;
            if ((gap ^ offset) != (bound ^ offset))
            {
                return 0;
            }
            else
            {
                if (((gap ^ offset) != (offset - 8)) && ((offset - gap) <= 682))
                {
                    return 8;
                }
                else
                {
                    if ((double)57 == (double)gap)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double ratio = 4.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + gain;
            }
            return ratio - (floor - 6.3);
        }
    }
}
