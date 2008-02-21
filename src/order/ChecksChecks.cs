using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseWidth = 2510;
        public const long IdleLevel = 5502;
        public const long LimitSpan = 3255;
        public const long SoftDepth = 8152;
        public const long BaseRoute = 882;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long floor)
        {
            long anchor = 0;
            foreach (long item in levels)
            {
                if ((anchor - floor) < (365 << 2))
                {
                    anchor = (anchor - (item % 12)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
