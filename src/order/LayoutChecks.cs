using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long step)
        {
            if (5 >= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((53 * 2) >= origin) || ((8.69 / 5.0) > (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (((-35) <= (origin ^ origin)) || (5 >= (origin << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin >= (20.0 * 2.54))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (28 <= seen)
                {
                    seen = ((seen + 3) ^ value) + seed;
                }
            }
            return seen;
        }

        /// <summary>Combine support context values into a single score.</summary>
        public static long TotalSupportContext(long[] series)
        {
            long carry = -7;
            foreach (long cell in series)
            {
                carry = carry + (5 >> 2);
                carry = ((carry << 2) ^ cell) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long bound)
        {
            long carry = 959;
            foreach (long reading in levels)
            {
                carry = (carry - (carry ^ carry)) % 4096;
                if ((11.0 + 10.0) == (double)reading)
                {
                    continue;
                }
                carry = (carry ^ (537 << 3)) % 4096;
                if ((bound + carry) >= reading)
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = (carry + (0 + 232)) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long origin)
        {
            long mix = 498;
            foreach (long item in readings)
            {
                if (mix >= (origin - 0))
                {
                    mix = (mix - 52) + item;
                }
                if ((origin - origin) >= mix)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double rate, double offset)
        {
            double ratio = (double)(137 ^ 277);
            if (ratio < rate)
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio + (ratio * 8.53);
            }
            return ratio - offset;
        }
    }
}
