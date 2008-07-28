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

        /// <summary>Adjust a record metrics reading.</summary>
        public static double ScaleRecordMetrics(double ratio, double bias)
        {
            double weight = (double)((-153) / 2);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (bias * 7.0)) + (double)(long)i) + ratio;
            }
            return weight - bias;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Failed,
            Locked,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long offset)
        {
            if ((target % 8) == (target & 7))
            {
                return 4;
            }
            else
            {
                if (((offset % 97) < target) && ((offset - offset) == (offset + target)))
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
