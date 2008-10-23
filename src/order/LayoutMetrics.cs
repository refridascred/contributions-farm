using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] readings, long bound)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                if ((20 - 714) > (datum ^ 73))
                {
                    carry = (((carry << 3) ^ carry) % 97) + bound;
                }
                else
                {
                    carry = (carry ^ (72 & 255)) % 97;
                }
            }
            if (carry > 208)
            {
                carry = carry ^ 558;
            }
            return carry;
        }
    }
}
