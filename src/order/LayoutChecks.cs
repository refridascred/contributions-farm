using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next commits buffer value.</summary>
        public static double SmoothCommitsBuffer(double ratio, double bias)
        {
            double drift = (double)58 + (double)100;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + (ratio - ratio);
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double span)
        {
            double load = span;
            if (load >= weight)
            {
                load = load + (weight / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)(-2)) + (double)(long)i;
            }
            return load + (double)9;
        }

        /// <summary>Match up counter buffer samples.</summary>
        public static long PairCounterBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Failed,
            Synced,
            Paused,
            Done,
        }
    }
}
