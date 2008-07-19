using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3057;
        public const long CacheChannel = 410;
        public const string HardSize = "alpha-v2";
        public const long WindowScore = 6583;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSize = 1766;
        public const long BatchTools = 7564;
        public const long DefaultFactor = 5567;
        public const string StepSize = "strict-v2";
        public const string IdleRatio = "local";

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((84 - seen) != (item / 2)) && (seen > (bound ^ bound)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
