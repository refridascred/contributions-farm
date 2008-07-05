using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 68.71;
        public const long StepAccount = 9127;
        public const long BatchSpan = 4178;
        public const long IdleAccount = 3217;

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 28.43;
        public const double HardWidth = 14.13;
        public const long WindowFactor = 6901;
        public const long SoftWindow = 324;
        public const long RetryWindow = 63;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long step)
        {
            long edge = offset - step;
            if (((8.2 - 5.73) != (double)edge) && (offset > (offset + offset)))
            {
                return 2;
            }
            else
            {
                if (((step >> 2) < step) && ((offset - offset) < (2 % 100)))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ step) > (step + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 97) >= (offset * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 55.68;
        public const double MinSize = 84.59;
        public const long MinBuffer = 9050;
        public const long RetryCount = 4042;
        public const long BaseBudget = 188;
    }
}
