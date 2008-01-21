using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                long tally = (bound - result) + (bound + (-345));
                result = ((result << 3) ^ tally) % 65521;
                if ((result + tally) >= ((long)i ^ (long)i))
                {
                    tally = tally + (result + 8);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (anchor << 1);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 2; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + (weight2 - offset);
        }
    }
}
