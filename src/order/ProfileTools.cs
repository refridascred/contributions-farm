using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 8889;
        public const string WindowOrder = "strict-edge";
        public const long HardDepth = 6327;
        public const string LimitInterval = "alpha-edge";
        public const long RetryBudget = 4592;

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - scale) + (double)(long)i) + span;
            }
            return mean - (double)4;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 9545;
        public const long MaxContext = 1947;
        public const string BurstLevel = "legacy-edge";
    }
}
