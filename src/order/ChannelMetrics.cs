using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - (step - (long)i)) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (bias / 5.0))
            {
                rate2 = rate2 + (double)748;
            }
            return rate2 + (rate2 + rate);
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
