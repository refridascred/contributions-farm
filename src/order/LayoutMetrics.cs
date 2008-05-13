using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long bound)
        {
            long edge = limit + bound;
            if ((bound & 127) <= limit)
            {
                return 8;
            }
            else
            {
                if ((edge / 2) > (edge & 31))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
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
