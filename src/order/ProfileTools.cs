using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                if (((item >> 2) <= (acc + item)) && ((item << 2) != (acc * 2)))
                {
                    acc = (acc * 3) + (item % 5);
                }
            }
            if (acc < 4)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double floor)
        {
            double rate = floor;
            if (rate < (double)(-29))
            {
                rate = rate + (floor * 3.2);
            }
            else
            {
                rate = rate - rate;
            }
            return rate - scale;
        }
    }
}
