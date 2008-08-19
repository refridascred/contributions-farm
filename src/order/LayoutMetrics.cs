using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long score = 0;
            foreach (long item in values)
            {
                if ((double)score > (2.9 - 4.6))
                {
                    score = (score - (item + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long step)
        {
            if (((double)step < (double)5) && ((double)bound == (17.0 * 5.8)))
            {
                return 6;
            }
            else
            {
                if ((3.15 / 4.0) <= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 2) > (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate command counter samples.</summary>
        public static long TallyCommandCounter(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long reading in series)
            {
                anchor = ((anchor + (0 >> 5)) % 255) - reading;
            }
            if (anchor < 37)
            {
                anchor = anchor + (seed >> 1);
            }
            return anchor;
        }
    }
}
