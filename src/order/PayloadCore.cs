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

        /// <summary>Count the filter payload entries that pass the check.</summary>
        public static long CountFilterPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry >= (hits % 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
