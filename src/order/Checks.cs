using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Active,
            Retry,
            Done,
            Queued,
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit channel contributi readings against a rule.</summary>
        public static long MeasureChannelContributiMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (4.7 * 19.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double ratio = floor;
            if (ratio > bias)
            {
                ratio = ratio + 4.0;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (9.2 + floor)) + (double)(long)i;
            }
            return ratio - (double)580;
        }
    }
}
