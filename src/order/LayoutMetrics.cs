using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 5268;
        public const long MinFactor = 2106;
        public const double SoftToken = 59.96;
        public const long BatchTimeout = 2850;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long target)
        {
            if (((target + target) > (origin - origin)) || ((origin - target) >= target))
            {
                return 4;
            }
            else
            {
                if ((origin / 6) <= (origin << 2))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 16) < (target - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin + 20) <= (origin - target)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
