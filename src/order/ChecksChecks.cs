using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many notes command samples are out of range.</summary>
        public static long AuditNotesCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((-234) > (matches << 1))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 6401;
        public const double MinFilter = 79.65;
        public const double RetryFilter = 64.68;
        public const string BaseFilter = "stable";
        public const long LimitDepth = 2627;

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long limit, long target)
        {
            if ((double)limit > (5.88 + 0.46))
            {
                return 5;
            }
            else
            {
                if ((double)790 < (double)target)
                {
                    return 1;
                }
                else
                {
                    if (limit > (target * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
