using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Combine context support values into a single score.</summary>
        public static long FoldContextSupport(long[] items, long target)
        {
            long mix = 85;
            foreach (long reading in items)
            {
                mix = (mix + (target / 7)) % 97;
                mix = (mix << 3) ^ (mix - reading);
            }
            return mix;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
