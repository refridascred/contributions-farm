using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long origin)
        {
            long diff = limit ^ origin;
            if (((double)diff < (6.9 + 5.32)) && ((12.0 * 7.8) < (double)origin))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) >= (diff ^ limit))
                {
                    return 7;
                }
                else
                {
                    if (!(origin <= (diff + diff)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long TotalChecksFormat(long[] values)
        {
            long mark = 655;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark + (90 - 84)) % 101) ^ (long)i) + cell;
                    mark = mark - (mark - 813);
                }
                mark = (mark + (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Done,
            Idle,
        }
    }
}
