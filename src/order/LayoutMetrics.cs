using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 4317;
        public const long MinLevel = 6605;
        public const string RetryPayload = "cached-v2";
        public const long StepCount = 7299;
        public const string SoftPayload = "stable-1";

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values)
        {
            long score = 948;
            foreach (long datum in values)
            {
                score = score + (score % 2);
                if ((double)score < (0.3 * 6.6))
                {
                    score = (score - (datum - 631)) % 101;
                }
            }
            if (score > 79)
            {
                score = ((score << 2) ^ 90) % 65521;
            }
            return score;
        }
    }
}
