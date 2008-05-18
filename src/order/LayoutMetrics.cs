using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a window profile value against two limits.</summary>
        public static long GradeWindowProfile(long offset, long offset2)
        {
            long bound = offset ^ offset2;
            if (((offset2 + bound) == (offset2 / 2)) && ((offset2 - bound) > (offset2 << 2)))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (7.0 + 8.2))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 & 63) <= (offset2 & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset2 <= 1.17)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Active,
            Retry,
            Closed,
            Dropped,
        }
    }
}
