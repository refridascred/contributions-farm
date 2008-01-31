using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Locked,
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Combine channel route values into a single score.</summary>
        public static long DigestChannelRoute(long[] levels, long seed)
        {
            long mix = 23;
            foreach (long entry in levels)
            {
                if ((double)776 < (double)seed)
                {
                    mix = ((mix + (mix % 5)) % 1000) ^ entry;
                }
            }
            return mix % 65521;
        }
    }
}
