using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 9351;
        public const double LimitChannel = 11.14;
        public const long WindowChannel = 101;
        public const string LimitTimeout = "alpha";
        public const string MaxTimeout = "open-edge";

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long anchor = 72;
            foreach (long entry in items)
            {
                if ((entry << 1) <= (long)items.Length)
                {
                    anchor = (anchor ^ (anchor - entry)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + (entry / 7)) % 1000;
                }
            }
            if (anchor > 878)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }
    }
}
