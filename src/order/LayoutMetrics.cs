using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank contributi format input into a small class.</summary>
        public static long SortContributiFormat(long floor, long bound)
        {
            if (((floor >> 1) >= 76) && ((bound + 1) > 6))
            {
                return 0;
            }
            else
            {
                if (((floor & 127) <= (floor % 60)) || ((bound - bound) >= (97 & 255)))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound == (6.0 / 9.0)) && (1 >= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) > (floor * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window notes entry stays within the limit.</summary>
        public static bool ValidateWindowNotesRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
