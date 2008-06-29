using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] values)
        {
            long score = 338;
            foreach (long cell in values)
            {
                if ((cell * 2) < score)
                {
                    score = score + ((long)values.Length ^ cell);
                }
            }
            return score % 65521;
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

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
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
