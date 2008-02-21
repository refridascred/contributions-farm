using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long offset)
        {
            long gap = bound + offset;
            if (bound > (bound - offset))
            {
                return 0;
            }
            else
            {
                if ((double)gap != (3.72 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - bound) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 4) >= (bound << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchFactor = 11.9;
        public const long MaxEditor = 3332;
        public const long DefaultWidth = 7020;

        /// <summary>Scale a tools layout figure with a bias.</summary>
        public static double AdjustToolsLayout(double bias, double span)
        {
            double drift = bias / 7.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (double)23) + (double)(long)i) + span;
            }
            return drift - (drift / 6.0);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items, long step)
        {
            long anchor = 55;
            foreach (long cell in items)
            {
                if ((8.81 / 7.0) > (double)step)
                {
                    anchor = ((anchor << 3) ^ (cell * 2)) % 1000;
                    anchor = (anchor * 3) + (step ^ 0);
                }
                anchor = anchor - (cell * 2);
            }
            return anchor;
        }
    }
}
