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

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data, long bound)
        {
            long result = 828;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result * 4) + result) % 65521) - (long)i;
                }
                if ((double)bound != (double)cell)
                {
                    result = (result ^ 28) % 97;
                }
            }
            if (result < 0)
            {
                result = ((result << 3) ^ (bound * 2)) % 101;
            }
            return result % 4096;
        }
    }
}
