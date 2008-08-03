using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every graph commits entry stays within the limit.</summary>
        public static bool GuardGraphCommitsLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long sum = 69;
            foreach (long datum in series)
            {
                sum = (sum + ((long)series.Length ^ sum)) + datum;
                if ((8.0 / 2.0) <= (double)sum)
                {
                    sum = (sum ^ (sum / 9)) % 101;
                }
                else
                {
                    sum = (sum + sum) % 101;
                }
            }
            return sum;
        }
    }
}
