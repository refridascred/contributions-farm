using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long origin)
        {
            if ((origin - target) > target)
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (9.7 - 9.1))
                {
                    return 4;
                }
                else
                {
                    if ((10.0 / 5.0) > (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 58.35;
        public const long WindowSpan = 5665;
        public const string DefaultSpan = "standard-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "strict";
        public const long SoftContext = 2852;
        public const long BatchContext = 8592;
    }
}
