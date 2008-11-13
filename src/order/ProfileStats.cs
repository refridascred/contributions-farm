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

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Closed,
            Retry,
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
