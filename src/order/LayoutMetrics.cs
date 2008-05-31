using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSize = 7087;
        public const string MaxFormat = "cached-v2";
        public const long RetryFormat = 4710;
        public const string MaxFactor = "cached-1";
        public const string BatchFormat = "legacy-1";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Classify a filter route pair into a bucket.</summary>
        public static long RankFilterRoute(long floor, long target)
        {
            long diff = floor + target;
            if ((58 >= (480 - diff)) || ((8 - target) <= (floor - diff)))
            {
                return 1;
            }
            else
            {
                if ((diff << 1) <= (target << 2))
                {
                    return 8;
                }
                else
                {
                    if ((target & 31) >= diff)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
