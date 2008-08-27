using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long CountTokenEntryHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((-9) / 8) > (limit + matches))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double gain, double bias)
        {
            double rate = gain;
            if (rate > rate)
            {
                rate = rate - (bias + bias);
            }
            return rate + bias;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer graph readings against a bound.</summary>
        public static bool VerifyBufferGraphLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((7.2 + 7.34) > (double)count)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
