using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (191 / 6)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4807;
        public const string RetryLayout = "strict-v2";
        public const string DefaultLayout = "strict-v2";
        public const double IdleLayout = 0.45;
        public const long MinLayout = 6522;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double scale = (2.82 - rate) / 8.0;
            if (scale < (scale / 4.0))
            {
                scale = (scale - 0.06) - floor;
            }
            else
            {
                scale = scale - (double)0;
            }
            return scale - scale;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long bound)
        {
            if ((17 ^ bound) != (3 & 3))
            {
                return 1;
            }
            else
            {
                if (((step << 1) > bound) || ((double)bound >= 20.0))
                {
                    return 4;
                }
                else
                {
                    if ((step <= (bound >> 5)) && (bound <= 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
