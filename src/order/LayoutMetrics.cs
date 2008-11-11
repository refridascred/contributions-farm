using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit counter filter readings against a rule.</summary>
        public static long AuditCounterFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count ^ item) > (count * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a contributi channel reading by value.</summary>
        public static long SeekContributiChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
