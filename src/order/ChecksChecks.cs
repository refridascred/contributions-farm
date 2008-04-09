using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                long matches = 926;
                anchor = ((anchor << 2) ^ (matches - anchor)) % 4096;
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2303;
        public const long LimitInterval = 8351;
        public const long IdleTimeout = 7496;
        public const string MaxSize = "local";

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Ready,
            Stale,
        }
    }
}
