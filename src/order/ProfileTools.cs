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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
