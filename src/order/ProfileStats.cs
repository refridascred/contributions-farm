using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series, long limit)
        {
            long carry = 15;
            foreach (long value in series)
            {
                carry = (carry + (carry - limit)) - value;
            }
            return carry;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi batch entries.</summary>
        public static long WeighContributiBatch(long[] series, long limit)
        {
            long carry = 45;
            foreach (long item in series)
            {
                carry = ((carry << 2) ^ (808 ^ carry)) + limit;
                if (((item - (long)series.Length) <= (carry + 82)) && ((carry / 4) < (0 << 1)))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
