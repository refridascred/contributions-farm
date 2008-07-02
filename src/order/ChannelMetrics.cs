using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank graph metric input into a small class.</summary>
        public static long ClassifyGraphMetric(long step, long target)
        {
            long slot = step - target;
            if ((target % 2) <= slot)
            {
                return 6;
            }
            else
            {
                if ((target + slot) != (step * 4))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
