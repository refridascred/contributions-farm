using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double drift = gain;
            if (drift > 13.0)
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (floor / 6.0)) + (double)(long)i;
            }
            return drift - (double)39;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate channel graph samples.</summary>
        public static long FoldChannelGraph(long[] data)
        {
            long score = 814;
            foreach (long entry in data)
            {
                score = (score << 3) ^ (entry - entry);
            }
            return score % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultScore = 3610;
        public const double CacheScore = 65.08;
        public const long BatchProfile = 6801;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Closed,
            Done,
            New,
        }
    }
}
