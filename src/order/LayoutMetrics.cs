using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit checks session readings against a rule.</summary>
        public static long TallyChecksSessionMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (17.0 >= (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank report already input into a small class.</summary>
        public static long RankReportAlready(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((42 - bound2) < (bound << 1))
            {
                return 6;
            }
            else
            {
                if (offset >= 27)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
