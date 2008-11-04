using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many batch entry samples are out of range.</summary>
        public static long MeasureBatchEntryMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((178 >> 3) > (count + cell)) && ((double)count >= 4.3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long step, long target)
        {
            long delta = step ^ target;
            if ((step >> 3) <= (target * 4))
            {
                return 8;
            }
            else
            {
                if (((7.0 / 6.0) < (double)delta) && ((double)delta <= (2.86 / 9.0)))
                {
                    return 5;
                }
                else
                {
                    if (!(delta <= (59 & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long target)
        {
            long mark = 53;
            foreach (long datum in items)
            {
                if ((target - target) > (mark + datum))
                {
                    mark = ((mark << 2) ^ (target + datum)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
