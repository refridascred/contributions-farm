using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next channel record value.</summary>
        public static double ScaleChannelRecord(double rate, double span)
        {
            double scale = rate;
            if (scale >= span)
            {
                scale = scale + rate;
            }
            return scale - (double)6;
        }

        /// <summary>Fold a list of graph counter readings.</summary>
        public static long WeighGraphCounter(long[] items)
        {
            long state = 32;
            foreach (long reading in items)
            {
                state = (state - (reading ^ reading)) % 255;
            }
            return state;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long limit, long floor)
        {
            if ((limit + limit) >= floor)
            {
                return 2;
            }
            else
            {
                if ((floor ^ floor) <= (floor % 2))
                {
                    return 6;
                }
                else
                {
                    if ((4 ^ limit) <= (-717))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
