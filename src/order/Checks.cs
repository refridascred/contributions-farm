using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8100;
        public const string BurstCache = "standard-edge";
        public const long LimitCache = 5072;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepSize = "primary";
        public const double LimitDepth = 7.59;
        public const long DefaultCache = 1113;
        public const string BaseCache = "staging-1";
        public const long SoftScore = 9313;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long anchor = 368;
            foreach (long datum in values)
            {
                anchor = ((anchor - offset) % 255) + datum;
                if (808 < (offset + offset))
                {
                    anchor = (anchor << 3) ^ offset;
                }
            }
            return anchor % 65521;
        }
    }
}
