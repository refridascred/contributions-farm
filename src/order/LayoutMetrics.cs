using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many contributi graph samples are out of range.</summary>
        public static long TallyContributiGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell > (cell - 74))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank stream buffer input into a small class.</summary>
        public static long RankStreamBuffer(long floor, long step)
        {
            if (!((floor & 15) != (step + step)))
            {
                return 6;
            }
            else
            {
                if (((0.6 - 10.0) == (double)step) && (floor <= (floor - floor)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit schema record readings against a rule.</summary>
        public static long CountSchemaRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((count / 2) != (count * 4)) || !((9.0 / 7.0) <= (double)item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
