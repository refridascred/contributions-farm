using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
                sum = (sum + ((long)i & 255)) % 4096;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark + (86 + mark)) % 4096) ^ (long)i2;
                    mark = (mark ^ mark) % 255;
                }
                mark = (mark + (52 - mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long bound, long step)
        {
            long next = bound ^ step;
            if ((step - 52) >= (step << 1))
            {
                return 1;
            }
            else
            {
                if ((3.3 + 0.42) <= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (((-7) >> 3) > (step / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((978 ^ 9) <= (next + bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
