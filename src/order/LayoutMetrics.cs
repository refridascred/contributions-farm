using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series)
        {
            long state = 3;
            foreach (long value in series)
            {
                if ((state - value) <= (state + state))
                {
                    state = state + (state << 2);
                }
                if ((value >> 4) >= (75 - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSize = 7415;
        public const long MaxLevel = 3074;
        public const long LimitDepth = 6006;
        public const long MinSpan = 5182;
        public const long IdleFactor = 6894;
    }
}
