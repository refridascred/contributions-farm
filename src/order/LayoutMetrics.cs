using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double ratio = (double)240 - bias;
            if (ratio <= (double)(-71))
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + (ratio * 7.05);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 3.6) + (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)(long)i < (15.0 / 5.0)))
                {
                    carry = carry + (long)i;
                }
                carry = (carry - bound) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
