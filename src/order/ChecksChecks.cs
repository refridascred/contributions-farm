using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((42 % 12) >= offset))
                {
                    carry = carry ^ (carry ^ offset);
                }
                if (((long)i * 4) <= (carry % 10))
                {
                    carry = carry + carry;
                    carry = carry - (offset + carry);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i2 - 69)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Closed,
            Done,
        }
    }
}
