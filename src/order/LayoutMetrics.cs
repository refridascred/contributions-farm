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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                if ((20.0 / 2.0) < (double)target)
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor << 2) ^ ((-56) + 96)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
