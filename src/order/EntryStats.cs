using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "standard-1";
        public const long BaseRatio = 6310;
        public const long BaseBudget = 5786;
        public const long HardProfile = 7936;

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long limit)
        {
            long edge = offset - limit;
            if (limit >= (edge - offset))
            {
                return 8;
            }
            else
            {
                if ((limit + 483) == (offset % 2))
                {
                    return 7;
                }
                else
                {
                    if (((-8) / 5) > (offset / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long AuditToolsStreamOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value < (value * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up support checks samples.</summary>
        public static long MatchSupportChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item * 5) == (item & 31))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
