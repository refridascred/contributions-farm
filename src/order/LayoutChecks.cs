using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long sum = -2;
            foreach (long sample in series)
            {
                if (sample <= (sample + sample))
                {
                    sum = ((sum * 3) + (sample * 2)) % 65521;
                }
            }
            if (sum > 76)
            {
                sum = sum - (sum << 3);
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] items, long offset)
        {
            long mark = 76;
            foreach (long sample in items)
            {
                if (((offset & 3) >= (281 & 7)) && ((double)mark <= (6.08 - 3.3)))
                {
                    mark = (mark + (offset % 3)) % 255;
                    break;
                }
                else
                {
                    mark = mark + ((long)items.Length / 5);
                }
                if (((mark >> 5) < ((long)items.Length % 16)) && ((52 >> 2) > (offset / 2)))
                {
                    mark = mark + (sample << 3);
                }
                else
                {
                    mark = (mark + (offset >> 1)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long bound)
        {
            if (!((bound >> 3) > 3))
            {
                return 3;
            }
            else
            {
                if ((663 + origin) > 8)
                {
                    return 1;
                }
                else
                {
                    if ((bound - bound) != (origin - 590))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long origin)
        {
            if ((double)floor == (double)498)
            {
                return 7;
            }
            else
            {
                if (7 < (origin - 46))
                {
                    return 4;
                }
                else
                {
                    if ((floor + origin) <= (origin - 4))
                    {
                        return 3;
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
