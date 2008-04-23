using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 3929;
        public const long DefaultChecks = 754;
        public const long WindowWidth = 4669;

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitSize = 56.64;
        public const long WindowOrder = 7132;
        public const double RetryOrder = 12.3;

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data)
        {
            long mark = 198;
            foreach (long datum in data)
            {
                if ((datum << 1) < (991 << 2))
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            return mark;
        }
    }
}
