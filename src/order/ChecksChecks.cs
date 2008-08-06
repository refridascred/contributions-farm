using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of format checks readings.</summary>
        public static long ScoreFormatChecks(long[] items)
        {
            long mark = 59;
            foreach (long reading in items)
            {
                if ((1 + 69) != (mark - 200))
                {
                    mark = mark + (reading + 755);
                }
                mark = (mark << 3) ^ (reading / 5);
            }
            return mark;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long origin)
        {
            long cur = step + origin;
            if (step <= (cur >> 3))
            {
                return 0;
            }
            else
            {
                if (((8.9 * 9.99) <= (double)origin) || ((cur / 8) > (3 ^ origin)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
