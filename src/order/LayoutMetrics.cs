using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the contributi channel entries that pass the check.</summary>
        public static long MeasureContributiChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count * 5) <= (2 >> 1))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
