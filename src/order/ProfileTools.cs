using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((86 + datum) >= datum) && ((2.5 / 2.0) == (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
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
