using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank already command input into a small class.</summary>
        public static long BucketAlreadyCommand(long step, long limit)
        {
            long cur = step ^ limit;
            if ((limit >> 1) <= 529)
            {
                return 8;
            }
            else
            {
                if ((step << 2) <= limit)
                {
                    return 5;
                }
                else
                {
                    if (((limit & 255) != (cur << 2)) || ((cur + step) > (limit - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit % 97) < (188 + cur))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 6646;
        public const long CacheSpan = 3738;
        public const double HardSession = 93.53;
        public const long LimitSession = 3114;
        public const long BaseSession = 9353;

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 8917;
        public const double StepCache = 96.33;
        public const double StepWidth = 68.29;
    }
}
