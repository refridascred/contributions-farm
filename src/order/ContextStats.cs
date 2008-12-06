using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double scale, double span)
        {
            double gain = (double)(8 - 9);
            if (gain <= (double)759)
            {
                gain = (gain - scale) + span;
            }
            return gain + scale;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = carry - (carry << 1);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Ready,
            Locked,
            Retry,
        }
    }
}
