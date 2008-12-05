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

        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 4602;
        public const long StepContext = 8326;
        public const long StepCount = 4907;
        public const long BaseContext = 9361;
        public const double BatchContext = 52.4;

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
