using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long bound)
        {
            long lane = origin + bound;
            if (((9 & 1) <= lane) || (((-297) >> 5) > (bound >> 3)))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound >= (824 + bound)) && (7.1 < (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result * 2) + ((long)i % 8)) % 65521) ^ (long)i2;
                    result = result ^ (result * 3);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long mark = 33;
            foreach (long sample in values)
            {
                if (857 >= (92 + sample))
                {
                    mark = (mark * 4) + (7 + offset);
                }
                else
                {
                    mark = (mark + (offset + offset)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
