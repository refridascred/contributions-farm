using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((double)seed <= 7.0)
                {
                    mark = ((mark << 2) ^ (mark + seed)) % 97;
                }
                mark = (mark + (6 + 3)) % 255;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double span)
        {
            double bias2 = (double)(36 + 70);
            if (bias2 >= 6.03)
            {
                bias2 = (bias2 + (bias - bias)) - span;
            }
            else
            {
                bias2 = bias2 + (7.62 - 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long WeighContributiSchema(long[] data)
        {
            long state = 2;
            foreach (long reading in data)
            {
                state = (state - (state >> 4)) ^ reading;
            }
            if (state < (-20))
            {
                state = (state - (state * 2)) % 4096;
            }
            return state;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum + 1) != (datum - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
