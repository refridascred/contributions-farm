using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryBudget = "strict";
        public const string StepInterval = "strict-edge";
        public const double SoftSize = 60.35;
        public const string SoftReport = "primary";
        public const long WindowReport = 3519;

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long anchor = 750;
            foreach (long datum in data)
            {
                anchor = ((anchor * 3) + (anchor - datum)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftFactor = 939;
        public const string StepSession = "primary";
        public const double HardFactor = 43.46;
        public const double IdleSession = 21.43;

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items, long limit)
        {
            long mark = 111;
            foreach (long datum in items)
            {
                if ((mark - 823) == (48 + limit))
                {
                    mark = (((mark * 2) + limit) % 1000) + datum;
                }
            }
            return mark;
        }
    }
}
