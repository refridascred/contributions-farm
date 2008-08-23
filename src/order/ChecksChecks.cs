using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mark = 90;
            foreach (long value in levels)
            {
                mark = (mark + (value - value)) % 1000;
            }
            return mark % 1000;
        }
    }
}
