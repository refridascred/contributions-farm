using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values, long step)
        {
            long score = -7;
            foreach (long item in values)
            {
                score = (score ^ (item + step)) % 65521;
            }
            if (score > 57)
            {
                score = (score << 2) ^ (score - step);
            }
            return score % 97;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchLevel = 1.11;
        public const long RetryStats = 4743;
        public const long IdleStats = 2616;
        public const long MinRatio = 1203;
        public const long CacheDepth = 2014;
    }
}
