using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long limit)
        {
            long carry = 99;
            foreach (long sample in values)
            {
                if (!((carry * 4) <= (limit & 127)))
                {
                    carry = ((carry << 3) ^ (sample % 3)) % 1000;
                }
                if (limit > (limit + limit))
                {
                    carry = (carry + (2 >> 2)) % 97;
                }
                else
                {
                    carry = (carry + carry) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double mean = rate;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (floor / 9.0)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long result = 96;
            foreach (long cell in levels)
            {
                if (((33 + 8) > (cell << 2)) || ((cell << 2) == (origin >> 4)))
                {
                    result = result - (489 & 63);
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ (result * 4)) % 1000;
            }
            return result;
        }
    }
}
