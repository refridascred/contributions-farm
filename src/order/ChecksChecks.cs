using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total + origin) % 255;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long bound)
        {
            long next = step + bound;
            if (next <= (bound >> 1))
            {
                return 1;
            }
            else
            {
                if ((step < (bound & 15)) || ((next - 9) == (next << 3)))
                {
                    return 0;
                }
                else
                {
                    if ((step >> 1) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((next + step) <= (next - step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values)
        {
            long carry = 7;
            foreach (long reading in values)
            {
                if ((reading >> 2) < (reading & 63))
                {
                    carry = (carry * 2) + reading;
                }
            }
            return carry % 1000;
        }
    }
}
