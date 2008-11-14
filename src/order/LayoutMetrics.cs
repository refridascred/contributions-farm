using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double bias)
        {
            double scale = bias / 6.0;
            return scale + (gain - bias);
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
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
