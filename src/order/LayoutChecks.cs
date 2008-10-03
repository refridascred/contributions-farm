using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardTimeout = 4.38;
        public const long MaxMetric = 6026;
        public const long BurstMetric = 3690;

        /// <summary>Roll a order counter counter forward.</summary>
        public static long DeriveOrderCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (anchor & 1)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinLevel = 6223;
        public const long SoftRatio = 9530;
        public const long HardBudget = 6342;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long origin)
        {
            if (9.0 > (double)seed)
            {
                return 8;
            }
            else
            {
                if (((seed >> 2) >= (origin * 2)) || ((seed % 7) <= (origin ^ seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 1) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((floor + (-7)) >= mark)
                {
                    mark = (mark - floor) % 97;
                    break;
                }
                mark = (mark + (mark / 7)) % 255;
                mark = mark - floor;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
