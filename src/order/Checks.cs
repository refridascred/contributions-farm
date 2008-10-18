using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Retry,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] samples)
        {
            long anchor = 44;
            foreach (long entry in samples)
            {
                if ((double)anchor == (1.0 * 5.6))
                {
                    anchor = ((anchor << 3) ^ (entry - entry)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor & 63)) % 97;
                }
                if (283 >= (entry + entry))
                {
                    anchor = anchor + (anchor ^ anchor);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor + 717)) % 97;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor - (anchor - anchor)) % 97;
            }
            return anchor;
        }
    }
}
