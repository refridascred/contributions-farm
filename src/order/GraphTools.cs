using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long limit)
        {
            if (((-56) >= (seed % 3)) && (seed > (seed / 8)))
            {
                return 2;
            }
            else
            {
                if (!((seed << 2) <= (limit / 8)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings, long origin)
        {
            long total = 9;
            foreach (long item in readings)
            {
                if ((double)item <= (2.0 + 7.8))
                {
                    total = ((total ^ (total - 11)) % 97) - origin;
                }
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstCount = "local-1";
        public const long BurstStats = 5140;
        public const string IdleWidth = "local-v2";
        public const long LimitStats = 8197;
        public const long DefaultDepth = 3858;

        /// <summary>Define context limits and defaults.</summary>
        public const long MinCount = 6865;
        public const long BaseRatio = 6732;
        public const double MaxFactor = 56.82;
    }
}
