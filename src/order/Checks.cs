using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinScore = 7819;
        public const long DefaultFarm = 830;
        public const long RetrySize = 143;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 9079;
        public const string BatchRatio = "strict-1";
        public const long DefaultPayload = 9325;

        /// <summary>Rank cache layout input into a small class.</summary>
        public static long ClassifyCacheLayout(long seed, long floor)
        {
            long prev = seed ^ floor;
            if ((5 - seed) > (seed + floor))
            {
                return 3;
            }
            else
            {
                if (((double)seed != (double)413) && ((seed / 5) <= (64 + prev)))
                {
                    return 7;
                }
                else
                {
                    if ((9 & 127) < prev)
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
