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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long mark = 396;
            foreach (long datum in data)
            {
                if ((mark >> 1) > mark)
                {
                    mark = (((mark << 2) ^ (step << 3)) % 4096) ^ datum;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ (mark - 10)) % 255;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 9545;
        public const long MaxContext = 1947;
        public const string BurstLevel = "legacy-edge";
    }
}
