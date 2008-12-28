using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] values, long target)
        {
            long anchor = 2;
            foreach (long entry in values)
            {
                if ((entry + entry) > entry)
                {
                    anchor = ((anchor + (entry - anchor)) % 101) + target;
                }
            }
            if (anchor < 789)
            {
                anchor = anchor - 3;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Ready,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((14 > (count << 3)) && (((value << 1) == (value % 64)) || ((count % 3) <= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
