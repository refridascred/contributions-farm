using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate channel stats samples.</summary>
        public static long FoldChannelStats(long[] levels)
        {
            long anchor = 55;
            foreach (long datum in levels)
            {
                anchor = (anchor ^ (datum >> 2)) % 65521;
                if (((anchor & 63) < (datum << 2)) || (anchor >= (2 / 3)))
                {
                    anchor = (anchor + (66 & 7)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 5) + (datum + anchor)) % 101;
                }
            }
            if (anchor < 245)
            {
                anchor = (anchor + 10) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
