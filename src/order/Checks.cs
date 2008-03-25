using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two metrics already measurements.</summary>
        public static double AdjustMetricsAlready(double scale, double span)
        {
            double drift = (double)9 - (span * 0.3);
            if (drift > (drift - scale))
            {
                drift = drift - 6.77;
            }
            return drift + (drift + span);
        }

        /// <summary>Fold a list of support farm readings.</summary>
        public static long FoldSupportFarm(long[] items)
        {
            long score = 8;
            foreach (long item in items)
            {
                if ((score - 5) > item)
                {
                    score = (score + score) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Digest a series of editor report entries.</summary>
        public static long FoldEditorReport(long[] levels, long floor)
        {
            long mix = 10;
            foreach (long cell in levels)
            {
                if (((long)levels.Length ^ mix) <= cell)
                {
                    mix = mix - (mix + floor);
                }
                else
                {
                    mix = mix + (cell + 85);
                }
            }
            return mix;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Stale,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long ClassifyStreamCommits(long seed, long bound)
        {
            if ((98 / 4) > bound)
            {
                return 4;
            }
            else
            {
                if ((seed + seed) != (bound + bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
