using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long step)
        {
            long step2 = bound - step;
            if ((step2 - step2) >= (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if (!((double)step2 > (4.2 * 1.0)))
                {
                    return 1;
                }
                else
                {
                    if ((step2 >= step) && (step < (bound >> 5)))
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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state - seed) % 1000;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state ^ seed) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample * 5) == (tally & 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
