using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long anchor = 750;
            foreach (long datum in data)
            {
                anchor = ((anchor * 3) + (anchor - datum)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Failed,
            New,
            Closed,
            Done,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (88 <= (matches + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
