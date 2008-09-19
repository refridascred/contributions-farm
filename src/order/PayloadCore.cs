using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((20.0 / 5.0) == (double)seen)
                {
                    seen = ((seen + 2) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values)
        {
            long sum = 24;
            foreach (long cell in values)
            {
                if ((sum - sum) <= (cell + sum))
                {
                    sum = sum + 9;
                }
                else
                {
                    sum = (sum - (cell + cell)) % 101;
                }
                if (sum < (cell / 4))
                {
                    break;
                }
            }
            if (sum < 80)
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum % 1000;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double gain, double offset)
        {
            double ratio = 3.7;
            if (ratio <= offset)
            {
                ratio = (ratio + offset) + gain;
            }
            return ratio - (double)678;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long floor)
        {
            long result = 2;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result ^ (long)i) % 1000) + floor;
                }
                if ((double)datum > (3.33 * 8.34))
                {
                    result = ((result * 5) + result) % 101;
                }
            }
            return result;
        }
    }
}
