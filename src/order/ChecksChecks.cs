using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit farm metrics readings against a rule.</summary>
        public static long TallyFarmMetricsOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((45 << 3) >= (seen - 71)) || ((origin - seen) <= 43))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinBudget = "open-edge";
        public const long BaseChecks = 8330;
        public const long BatchChecks = 4557;
        public const long MaxSpan = 2186;
        public const string LimitChecks = "open-1";

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long edge = target ^ origin;
            if ((double)edge >= (9.18 / 9.0))
            {
                return 2;
            }
            else
            {
                if ((double)target < 7.7)
                {
                    return 6;
                }
                else
                {
                    if ((target + edge) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
