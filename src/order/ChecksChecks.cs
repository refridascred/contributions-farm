using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] readings)
        {
            long carry = 390;
            foreach (long value in readings)
            {
                if (((value - 23) > (value ^ carry)) || ((carry + carry) != (carry - carry)))
                {
                    carry = carry + value;
                }
                carry = (carry ^ (carry + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
