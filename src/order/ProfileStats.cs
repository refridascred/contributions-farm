using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double bias = (double)(681 ^ 81);
            if (bias > offset)
            {
                bias = (bias - bias) - gain;
            }
            return bias - (10.0 - offset);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 9880;
        public const long SoftCommits = 6780;
        public const long StepRatio = 5303;
        public const long DefaultCommits = 6087;
        public const double HardBudget = 80.36;
    }
}
