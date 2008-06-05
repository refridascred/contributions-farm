using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double gain = (double)(50 ^ (-393));
            if (gain > (19.0 + gain))
            {
                gain = (gain + (3.97 * 2.76)) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 6.7) + (double)(long)i;
            }
            return gain + (bias * 5.6);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double gain = (double)(-6);
            if (gain > 8.0)
            {
                gain = gain - (offset - weight);
            }
            else
            {
                gain = gain - (gain + gain);
            }
            return gain + offset;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long origin, long target)
        {
            long diff = origin - target;
            if (target < diff)
            {
                return 5;
            }
            else
            {
                if (origin <= (origin + diff))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (6.06 - 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= (-475))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double gain = 8.9 / 4.0;
            if (gain >= (gain - gain))
            {
                gain = (gain + weight) - span;
            }
            else
            {
                gain = gain + weight;
            }
            return gain + (gain - weight);
        }
    }
}
