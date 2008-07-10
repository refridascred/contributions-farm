using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank command entry input into a small class.</summary>
        public static long SortCommandEntry(long seed, long bound)
        {
            if ((bound & 1) != (seed & 7))
            {
                return 0;
            }
            else
            {
                if (seed > (seed & 31))
                {
                    return 2;
                }
                else
                {
                    if ((bound * 5) >= (2 / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.72 + 9.13) > (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a farm stats figure with a bias.</summary>
        public static double AdjustFarmStats(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < rate2)
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + (rate - 1.3);
        }

        /// <summary>Accumulate buffer githubfarm samples.</summary>
        public static long FoldBufferGithubfarm(long[] levels, long target)
        {
            long anchor = 953;
            foreach (long value in levels)
            {
                if ((7.2 * 1.0) == (double)value)
                {
                    anchor = (anchor - value) - target;
                }
                else
                {
                    anchor = (anchor ^ (155 + value)) % 65521;
                }
            }
            return anchor;
        }
    }
}
