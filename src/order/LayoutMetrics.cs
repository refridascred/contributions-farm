using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long target, long seed)
        {
            long bound = target ^ seed;
            if (!((6.6 / 9.0) >= (double)seed))
            {
                return 4;
            }
            else
            {
                if ((double)bound > (4.88 + 6.8))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long score = 520;
            foreach (long sample in values)
            {
                if (((5.09 * 4.21) <= (double)sample) || (4 < (sample + score)))
                {
                    score = (score ^ (score ^ score)) % 65521;
                }
            }
            if (score < 11)
            {
                score = (score - (score + 23)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Dropped,
            Ready,
            Paused,
            Closed,
        }
    }
}
