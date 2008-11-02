using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long offset)
        {
            long next = seed + offset;
            if (!(seed > (offset % 24)))
            {
                return 1;
            }
            else
            {
                if ((12.0 + 5.0) > (6.8 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if (((seed ^ next) > ((-939) - 899)) && ((seed % 7) < (offset ^ next)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-664) / 5) <= (next * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6088;
        public const long LimitWidth = 3411;
        public const string MaxProfile = "strict-v2";

        /// <summary>Grade a account route value against two limits.</summary>
        public static long SortAccountRoute(long floor, long step)
        {
            if (((double)floor >= 6.48) || ((3.9 + 2.42) != (double)step))
            {
                return 4;
            }
            else
            {
                if ((step - 86) != (floor + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)290 < (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] series, long origin)
        {
            long acc = 4;
            foreach (long entry in series)
            {
                acc = ((acc * 3) + (origin - 899)) + entry;
            }
            return acc;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
