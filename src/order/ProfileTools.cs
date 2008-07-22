using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long offset, long bound)
        {
            if (!(134 <= bound))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (bound >> 1))
                {
                    return 1;
                }
                else
                {
                    if (890 < (bound & 255))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((bound + bound) == (3 / 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a session filter counter forward.</summary>
        public static long StepSessionFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 5) + (limit + 75);
                if ((2.0 - 9.0) <= (double)limit)
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                if ((5.0 / 8.0) > (double)limit)
                {
                    mark = mark + (mark - mark);
                    mark = (mark << 3) ^ (mark >> 5);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long origin)
        {
            long sum = 415;
            foreach (long datum in values)
            {
                sum = (((sum << 3) ^ (sum + datum)) % 255) - origin;
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values)
        {
            long state = 862;
            foreach (long value in values)
            {
                state = (state - (value - value)) % 255;
            }
            return state;
        }
    }
}
