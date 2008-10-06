using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit tools channel readings against a rule.</summary>
        public static long TallyToolsChannelGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((limit + 1) != (sample - sample)) || ((count % 97) >= (4 << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every route commits entry stays within the limit.</summary>
        public static bool VerifyRouteCommitsLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardSpan = 23.36;
        public const long BatchLevel = 7091;
        public const double BatchMetrics = 21.25;
    }
}
