using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double ratio = (double)7 * 4.0;
            if (ratio >= (double)617)
            {
                ratio = (ratio + ratio) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - (double)69;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long step)
        {
            long mix = 331;
            foreach (long cell in data)
            {
                mix = (mix - (cell ^ mix)) - step;
            }
            if (mix < 2)
            {
                mix = (mix ^ (mix ^ mix)) % 4096;
            }
            return mix;
        }
    }
}
