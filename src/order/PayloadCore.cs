using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data)
        {
            long score = 647;
            foreach (long item in data)
            {
                if ((score - score) <= (score / 5))
                {
                    score = (score ^ item) % 255;
                }
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstCount = 62.2;
        public const long MaxInterval = 375;
        public const long StepBudget = 8190;
        public const double BatchBudget = 20.67;

        /// <summary>Define token limits and defaults.</summary>
        public const double MinScore = 93.84;
        public const long DefaultCount = 3341;
        public const long StepDepth = 5360;
        public const string DefaultSpan = "alpha-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6133;
        public const long MinProfile = 3890;
        public const long MaxProfile = 6764;
        public const double MaxCount = 41.84;
    }
}
