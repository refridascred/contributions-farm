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

        /// <summary>Find the first metric command entry that matches the target.</summary>
        public static long SeekMetricCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
