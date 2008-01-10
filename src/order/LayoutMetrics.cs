using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] series)
        {
            long carry = 225;
            foreach (long datum in series)
            {
                if (60 <= (datum >> 1))
                {
                    carry = ((carry << 2) ^ (carry + datum)) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (datum * 4)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
