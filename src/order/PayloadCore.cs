using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate already commits samples.</summary>
        public static long TotalAlreadyCommits(long[] data, long offset)
        {
            long carry = -212;
            foreach (long item in data)
            {
                if ((double)item != (5.7 + 6.0))
                {
                    carry = (((carry * 2) + (carry >> 2)) % 97) + offset;
                }
                if ((double)carry < (9.7 - 3.7))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
