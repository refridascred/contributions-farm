using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepRatio = 3477;
        public const long BurstOrder = 9874;
        public const long BaseLevel = 606;
        public const long MaxOrder = 5161;
        public const long SoftOrder = 2963;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample < floor) || !((1.0 / 6.0) < (double)floor))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "fallback";
        public const string StepChannel = "legacy-1";
        public const long BurstSize = 2311;
        public const long BurstWidth = 3568;

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
