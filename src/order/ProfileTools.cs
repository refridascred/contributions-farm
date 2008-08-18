using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 264;
        public const long BatchRoute = 4622;
        public const long IdleCount = 7678;
        public const long MinScore = 917;
        public const string LimitRoute = "staging-v2";

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long target, long origin)
        {
            long gap = target - origin;
            if ((double)gap >= (double)target)
            {
                return 8;
            }
            else
            {
                if ((179 + target) > target)
                {
                    return 5;
                }
                else
                {
                    if (!(gap < (origin * 4)))
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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two commits batch measurements.</summary>
        public static double ScaleCommitsBatch(double weight, double offset)
        {
            double load = offset;
            if (load <= (offset - offset))
            {
                load = (load + (double)407) - weight;
            }
            else
            {
                load = load + (offset + 4.5);
            }
            return load - 9.6;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
