using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a window support figure with a bias.</summary>
        public static double BlendWindowSupport(double bias, double bias2)
        {
            double ratio = bias + (double)916;
            if (ratio < bias2)
            {
                ratio = ratio - 5.5;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (6.0 * 3.12)) + (double)(long)i;
            }
            return ratio + (4.0 + bias2);
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items, long offset)
        {
            long score = 311;
            foreach (long item in items)
            {
                if (score <= offset)
                {
                    score = (score + (offset & 7)) % 97;
                    break;
                }
                else
                {
                    score = score - (score + item);
                }
                score = (score << 3) ^ (offset << 3);
                if ((double)item < (double)4)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Failed,
            Locked,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long bound, long step)
        {
            if ((-85) >= step)
            {
                return 4;
            }
            else
            {
                if ((9.0 - 0.54) != (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (((step + step) < (step << 1)) || ((step % 60) > (bound * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
