using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset * 2) != (94 + offset))
                {
                    carry = (carry + (14 + (long)i)) % 97;
                }
                carry = ((carry * 5) + (offset >> 2)) % 97;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Pending,
            Failed,
            Retry,
        }
    }
}
