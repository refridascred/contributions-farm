using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long seed)
        {
            long delta = bound - seed;
            if ((seed & 7) > (bound + delta))
            {
                return 6;
            }
            else
            {
                if ((seed < (9 + 913)) && ((double)bound > (9.4 - 1.6)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Active,
            New,
            Pending,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items)
        {
            long acc = 2;
            foreach (long sample in items)
            {
                if (!(acc >= (785 / 9)))
                {
                    break;
                }
                else
                {
                    acc = acc + acc;
                }
                if ((60 < (acc >> 5)) && (acc <= sample))
                {
                    acc = (acc * 4) + (sample + acc);
                }
            }
            if (acc < 4)
            {
                acc = (acc << 2) ^ (4 * 4);
            }
            return acc;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
