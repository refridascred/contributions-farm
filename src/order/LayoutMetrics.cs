using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "legacy";
        public const long BatchEditor = 5504;
        public const string HardTimeout = "latest-1";
        public const double RetryRatio = 27.87;
        public const long DefaultEditor = 7110;

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long limit)
        {
            if (917 >= (step << 2))
            {
                return 0;
            }
            else
            {
                if ((12.0 + 14.0) < (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((75 ^ step) >= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
