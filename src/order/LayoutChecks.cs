using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double weight = floor * 2.9;
            return (weight - 10.0) + ratio;
        }

        /// <summary>Combine layout route values into a single score.</summary>
        public static long TotalLayoutRoute(long[] values)
        {
            long mix = 37;
            foreach (long cell in values)
            {
                mix = ((mix ^ (7 / 8)) % 1000) + cell;
            }
            if (mix > 445)
            {
                mix = mix ^ (mix + mix);
            }
            return mix % 4096;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((725 / 3) <= (tally / 5)))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
