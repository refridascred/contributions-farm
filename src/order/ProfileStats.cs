using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long bound)
        {
            long slot = offset - bound;
            if ((slot << 1) < (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((bound + 488) >= (offset >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((5 + offset) >= (4 + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.8 + 4.27) != (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the layout graph series from a seed.</summary>
        public static long DeriveLayoutGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                if ((double)total > (8.5 - 4.03))
                {
                    total = total + (total + total);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up record stream samples.</summary>
        public static long CompareRecordStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
