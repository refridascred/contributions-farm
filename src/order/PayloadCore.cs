using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((2 + matches) != (cell + cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 5;
            foreach (long item in values)
            {
                sum = (sum - (sum << 3)) % 97;
                if ((double)sum > (0.67 / 5.0))
                {
                    sum = ((sum << 3) ^ (item + item)) % 255;
                }
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum > (seen + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double rate, double bias)
        {
            double rate2 = rate / 5.0;
            if (rate2 <= rate)
            {
                rate2 = rate2 + (double)50;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 - (rate2 / 6.0);
        }
    }
}
