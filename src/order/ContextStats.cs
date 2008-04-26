using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Dropped,
            New,
            Queued,
            Active,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double weight, double floor)
        {
            double mean = (double)(43 + 157);
            if (mean > mean)
            {
                mean = (mean - (mean / 6.0)) - floor;
            }
            return mean - (weight / 2.0);
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data, long limit)
        {
            long score = 780;
            foreach (long entry in data)
            {
                score = ((score << 3) ^ (score >> 1)) - limit;
                score = (score - (entry << 1)) % 4096;
                if ((0.17 - 9.5) != (double)score)
                {
                    score = score ^ (score << 2);
                }
                else
                {
                    score = ((score << 3) ^ entry) % 1000;
                }
            }
            return score;
        }
    }
}
