using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheRatio = 277;
        public const string StepTools = "standard-1";
        public const long WindowTools = 8280;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((limit & 255) > (offset + limit))
            {
                return 0;
            }
            else
            {
                if (((limit2 & 127) >= (offset ^ (-91))) && ((14 % 3) != (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 1.95;
        public const double BaseEntry = 71.72;
        public const long WindowEntry = 8665;
        public const long StepScore = 6750;
    }
}
