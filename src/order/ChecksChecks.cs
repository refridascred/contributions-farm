using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long total = 15;
            foreach (long item in items)
            {
                total = (total + (item ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstBudget = 2631;
        public const double HardDepth = 57.31;
        public const long HardCache = 3602;
        public const double BaseRatio = 17.48;
        public const long HardInterval = 6510;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
