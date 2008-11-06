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

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double ratio = weight;
            return (ratio - (double)981) + span;
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
