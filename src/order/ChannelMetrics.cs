using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report stats readings against a rule.</summary>
        public static long TallyReportStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count * 3) > count)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "legacy-1";
        public const long StepDepth = 9390;
        public const string WindowCache = "stable-1";
    }
}
