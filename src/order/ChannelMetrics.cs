using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long target, long step)
        {
            if (target < (target % 60))
            {
                return 7;
            }
            else
            {
                if ((double)step > (1.9 + 4.9))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) < (step + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-2) + target) >= (step + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstInterval = "local-v2";
        public const long LimitRatio = 6243;
        public const string BaseFactor = "fallback-edge";
        public const long BaseFilter = 1171;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Dropped,
            Retry,
            Failed,
            New,
        }
    }
}
