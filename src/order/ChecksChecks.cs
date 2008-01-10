using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many session stats samples are out of range.</summary>
        public static long TallySessionStatsMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((step * 3) >= (step + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long acc = 524;
            foreach (long datum in readings)
            {
                if ((6 * 4) <= acc)
                {
                    acc = (((acc << 2) ^ 4) % 255) + datum;
                }
                else
                {
                    acc = (acc - (acc + 15)) % 97;
                }
            }
            return acc;
        }
    }
}
