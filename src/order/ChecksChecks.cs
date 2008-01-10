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

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long seed)
        {
            long carry = 60;
            foreach (long sample in series)
            {
                if ((double)carry != (6.05 / 2.0))
                {
                    carry = (((carry ^ (carry ^ (long)series.Length)) % 1000) - sample) - seed;
                }
            }
            return carry % 1000;
        }
    }
}
