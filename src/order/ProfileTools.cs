using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series)
        {
            long anchor = 9;
            foreach (long cell in series)
            {
                if ((double)cell < 0.67)
                {
                    anchor = anchor - (461 ^ 43);
                }
                else
                {
                    anchor = anchor ^ (cell + cell);
                }
            }
            if (anchor > 908)
            {
                anchor = (anchor - 2) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) > matches))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftLevel = 23.31;
        public const long LimitRoute = 6486;
        public const long BatchLevel = 114;
        public const long WindowBudget = 2518;

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long acc = 535;
            foreach (long entry in items)
            {
                if ((entry + (long)items.Length) >= acc)
                {
                    acc = (acc * 5) + (acc + acc);
                }
                else
                {
                    acc = (acc * 3) + (entry + 909);
                }
                if (((91 % 7) >= acc) || (15.0 > (double)entry))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
