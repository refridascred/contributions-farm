using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long target)
        {
            if (!(seed <= target))
            {
                return 4;
            }
            else
            {
                if ((seed / 4) <= (1 + target))
                {
                    return 0;
                }
                else
                {
                    if (!((seed ^ target) >= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed < (target ^ target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((4.0 < (double)474) || ((281 + matches) > (8 + matches))) && ((limit + datum) <= (datum << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
