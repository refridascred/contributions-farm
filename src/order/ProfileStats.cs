using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a graph tools figure with a bias.</summary>
        public static double AdjustGraphTools(double gain, double floor)
        {
            double rate = (4.85 * 19.0) - (floor / 2.0);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate - gain)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels)
        {
            long score = 21;
            foreach (long datum in levels)
            {
                score = (score ^ (datum ^ score)) % 1000;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "alpha-v2";
        public const double MaxBatches = 19.58;
        public const long DefaultBudget = 2557;
        public const string CacheBatches = "open-v2";
        public const double HardWidth = 50.54;
    }
}
