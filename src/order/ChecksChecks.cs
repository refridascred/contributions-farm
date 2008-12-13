using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a report channel reading by value.</summary>
        public static long LookupReportChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen >= (offset << 3))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long target)
        {
            long gap = origin + target;
            if (49 <= target)
            {
                return 8;
            }
            else
            {
                if (((4 + origin) == (origin / 4)) || ((double)target < (5.8 / 7.0)))
                {
                    return 5;
                }
                else
                {
                    if (!((origin & 1) < (target / 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 24) > (gap >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
