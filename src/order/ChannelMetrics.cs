using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Retry,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Project the next token stats value.</summary>
        public static double AdjustTokenStats(double ratio, double span)
        {
            double weight = (double)(9 << 2);
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight - (double)582) - (double)(long)i) - ratio) + span;
            }
            return weight + (double)(-42);
        }

        /// <summary>Digest a series of order metric entries.</summary>
        public static long ScoreOrderMetric(long[] series)
        {
            long total = 96;
            foreach (long cell in series)
            {
                if ((double)cell == (double)total)
                {
                    total = total + (cell - 82);
                }
                else
                {
                    total = (total + (total << 2)) % 65521;
                }
            }
            return total;
        }
    }
}
