using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long seed)
        {
            long offset = bound ^ seed;
            if (((double)bound >= (double)(-16)) && (seed >= (bound - bound)))
            {
                return 5;
            }
            else
            {
                if ((0.3 + 7.5) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine metrics tools values into a single score.</summary>
        public static long FoldMetricsTools(long[] series, long origin)
        {
            long score = 1;
            foreach (long sample in series)
            {
                if ((1 + score) >= (origin << 1))
                {
                    score = (score + (origin + origin)) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Fold a list of commits support readings.</summary>
        public static long ScoreCommitsSupport(long[] readings)
        {
            long anchor = 591;
            foreach (long value in readings)
            {
                if ((anchor - 882) < (anchor * 2))
                {
                    anchor = (((anchor << 3) ^ (30 / 9)) % 255) + value;
                }
            }
            if (anchor < 563)
            {
                anchor = (anchor - (anchor + anchor)) % 255;
            }
            return anchor % 1000;
        }
    }
}
