using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = scale + (double)856;
            }
            else
            {
                scale = scale - (span / 3.0);
            }
            return scale + (scale + span);
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Fold a list of token account readings.</summary>
        public static long TallyTokenAccount(long[] levels, long seed)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                if ((seed << 1) <= (22 % 24))
                {
                    mix = mix ^ (cell << 1);
                    break;
                }
                if (!(9 > seed))
                {
                    mix = (mix * 5) + (seed + (long)levels.Length);
                }
            }
            return mix;
        }
    }
}
