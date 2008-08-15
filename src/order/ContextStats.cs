using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftSpan = "local-1";
        public const long BurstTimeout = 4991;
        public const long IdleToken = 3826;
        public const double LimitToken = 78.47;

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long step)
        {
            if (!((step + step) >= (floor << 2)))
            {
                return 2;
            }
            else
            {
                if (!(floor > (floor + step)))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) > (step - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two format payload measurements.</summary>
        public static double ProjectFormatPayload(double ratio, double span)
        {
            double gain = ratio - span;
            if (gain <= span)
            {
                gain = gain - span;
            }
            return gain + (double)524;
        }
    }
}
