using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long floor)
        {
            if (!(3.7 > (double)offset))
            {
                return 8;
            }
            else
            {
                if ((floor < (offset + floor)) || ((floor - offset) != (offset % 60)))
                {
                    return 5;
                }
                else
                {
                    if (194 <= (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally + entry) > (tally * 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >> 2) > (tally ^ offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
