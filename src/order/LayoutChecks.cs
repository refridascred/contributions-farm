using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double bias2 = ratio / 9.0;
            return (bias2 + ratio) + bias;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double mean = weight;
            if (mean >= (double)684)
            {
                mean = (mean - (double)15) + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 2.0)) + (double)(long)i;
            }
            return mean - (double)758;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading & 255) >= target) && ((target + (long)series.Length) > (target + 944)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Idle,
            Retry,
            Done,
        }
    }
}
