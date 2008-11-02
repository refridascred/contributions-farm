using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next channel stats value.</summary>
        public static double AdjustChannelStats(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)(long)i) - ratio;
            }
            return rate - rate;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many payload contributi samples are out of range.</summary>
        public static long TallyPayloadContributiOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches ^ sample) >= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
