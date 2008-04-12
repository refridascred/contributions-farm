using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = result ^ (result & 3);
                if (!((9.0 / 2.0) <= (double)seed))
                {
                    result = (result + ((long)i ^ (long)i)) % 97;
                    result = (result * 4) + (seed / 2);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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
