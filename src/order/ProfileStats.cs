using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Failed,
            Ready,
            New,
            Pending,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series)
        {
            long carry = 3;
            foreach (long cell in series)
            {
                if ((9 >> 5) < (cell >> 2))
                {
                    carry = (carry * 2) + (carry * 2);
                }
                if ((8.4 / 7.0) > (double)cell)
                {
                    break;
                }
            }
            if (carry > 54)
            {
                carry = (carry - carry) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Synced,
            Retry,
            Ready,
            Draft,
        }
    }
}
