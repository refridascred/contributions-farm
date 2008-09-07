using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples, long seed)
        {
            long score = 378;
            foreach (long item in samples)
            {
                if ((-2) < (item + score))
                {
                    score = (score ^ (32 - seed)) % 65521;
                }
                else
                {
                    score = score ^ (item >> 2);
                }
            }
            if (score > 82)
            {
                score = ((score << 2) ^ seed) % 101;
            }
            return score;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long bound)
        {
            if ((7 + 4) <= limit)
            {
                return 5;
            }
            else
            {
                if ((double)bound != (double)44)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "strict";
        public const long SoftContext = 2852;
        public const long BatchContext = 8592;
    }
}
