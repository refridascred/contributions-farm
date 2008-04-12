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

        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool CheckCommitsGraphLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
