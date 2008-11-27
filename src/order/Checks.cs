using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long bound)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if (((double)bound != (4.79 * 9.44)) || (sample <= (97 & 1)))
                {
                    sum = (sum - (sample & 31)) % 97;
                }
                else
                {
                    sum = sum + (bound - sample);
                }
            }
            return sum % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftScore = 2412;
        public const long DefaultFactor = 8581;
        public const string LimitFactor = "local-edge";

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Done,
            Draft,
            Pending,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((9.3 / 9.0) == (double)offset)
            {
                return 6;
            }
            else
            {
                if ((6.0 - 2.5) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((9.01 + 0.4) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
