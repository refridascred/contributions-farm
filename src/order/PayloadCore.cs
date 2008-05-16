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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long offset, long offset2)
        {
            if ((5.1 + 1.6) == (double)offset2)
            {
                return 6;
            }
            else
            {
                if ((offset + offset) >= 726)
                {
                    return 5;
                }
                else
                {
                    if (!((offset2 + offset) >= offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
