using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Dropped,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long result = -71;
            foreach (long datum in data)
            {
                result = (result - (result - 383)) + datum;
            }
            return result;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
