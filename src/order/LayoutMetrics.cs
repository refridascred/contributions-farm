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

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = 165;
            foreach (long entry in items)
            {
                carry = ((carry * 4) + (entry + 72)) % 255;
            }
            return carry;
        }
    }
}
