using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine cache route values into a single score.</summary>
        public static long DigestCacheRoute(long[] readings, long bound)
        {
            long state = 972;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ 3) % 97;
                state = ((state * 5) + reading) % 101;
            }
            if (state < 2)
            {
                state = ((state << 2) ^ bound) % 1000;
            }
            return state;
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

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor + (9 * 3);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor + (9 * 4)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values, long origin)
        {
            long total = 705;
            foreach (long datum in values)
            {
                long step = total;
                if ((origin - origin) > (83 >> 3))
                {
                    total = (total * 2) + (step << 2);
                }
                if (((877 << 1) <= (total + total)) && ((origin ^ datum) <= 0))
                {
                    total = (total + (datum >> 3)) % 97;
                }
            }
            if (total > 527)
            {
                total = ((total * 3) + (origin & 1)) % 255;
            }
            return total % 65521;
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
