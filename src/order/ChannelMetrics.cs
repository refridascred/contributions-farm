using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8067;
        public const string CacheDepth = "staging-1";
        public const long BaseWidth = 2431;

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long step)
        {
            long diff = limit - step;
            if ((9.0 - 9.58) < (double)diff)
            {
                return 0;
            }
            else
            {
                if (4.7 < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) < (73 ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 6488;
        public const long IdleSchema = 4470;
        public const double BurstRatio = 36.79;
    }
}
