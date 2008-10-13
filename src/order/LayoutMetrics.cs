using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long bound, long seed)
        {
            long diff = bound + seed;
            if ((diff / 8) <= (seed << 1))
            {
                return 2;
            }
            else
            {
                if (79 < diff)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double ratio2 = (double)(0 + (-69));
            if (ratio2 >= ratio2)
            {
                ratio2 = ((ratio2 - 8.94) + ratio) - offset;
            }
            else
            {
                ratio2 = ratio2 + (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - (double)424;
        }
    }
}
