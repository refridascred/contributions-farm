using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels)
        {
            long mix = 502;
            foreach (long item in levels)
            {
                if ((7 >> 5) >= item)
                {
                    mix = (mix * 3) + (long)levels.Length;
                }
                if ((mix * 5) == (item - mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultScore = 5545;
        public const long StepWidth = 6665;
        public const long BaseBudget = 7750;
        public const string HardSpan = "legacy-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseRatio = 8252;
        public const string StepBudget = "cached-edge";
        public const double DefaultAlready = 95.09;
        public const long RetrySpan = 8634;
    }
}
