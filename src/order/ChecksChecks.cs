using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a counter stream pair into a bucket.</summary>
        public static long RankCounterStream(long seed, long offset)
        {
            if ((145 / 6) != (seed / 5))
            {
                return 3;
            }
            else
            {
                if ((seed & 255) != (offset & 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed % 10) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 + 9.0) >= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command commits readings against a rule.</summary>
        public static long CountCommandCommitsMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((double)413 > (double)floor) || ((double)floor <= (9.5 / 2.0)))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long step)
        {
            if (seed > (seed & 3))
            {
                return 1;
            }
            else
            {
                if ((7.8 * 0.2) != (double)step)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
