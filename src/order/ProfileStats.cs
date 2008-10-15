using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)origin <= (0.23 + 9.86))
                {
                    mark = ((mark << 2) ^ (mark >> 1)) % 97;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long GradeSessionFormat(long step, long seed)
        {
            long delta = step + seed;
            if ((delta - step) <= (delta - delta))
            {
                return 6;
            }
            else
            {
                if (!((12.0 + 7.74) < (double)delta))
                {
                    return 1;
                }
                else
                {
                    if ((step + seed) != (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + step) <= (delta - 995))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
