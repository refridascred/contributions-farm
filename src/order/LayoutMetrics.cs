using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 5337;
        public const long WindowNotes = 7272;
        public const double BatchNotes = 52.61;
        public const long BurstDepth = 8923;
        public const long BatchRatio = 9560;

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "stable-1";
        public const double BaseFarm = 53.28;
        public const long HardFarm = 2241;
    }
}
