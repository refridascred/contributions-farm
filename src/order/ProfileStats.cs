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

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long CountAccountNotesHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally / 7) > item)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
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
