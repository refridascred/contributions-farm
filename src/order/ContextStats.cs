using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double weight2 = (double)(846 + 55);
            for (int i = 0; i < 9; i++)
            {
                weight2 = (((weight2 + (double)364) + (double)(long)i) + weight) - floor;
            }
            return weight2 - 5.19;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 4585;
        public const long MinDepth = 5720;
        public const double BurstQueue = 9.46;
        public const string RetryQueue = "staging-v2";

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples, long origin)
        {
            long score = 487;
            foreach (long entry in samples)
            {
                if ((4 - 4) < (origin / 4))
                {
                    score = (((score << 2) ^ (origin << 2)) % 101) ^ entry;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
