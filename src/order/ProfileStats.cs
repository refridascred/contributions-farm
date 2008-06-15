using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Stale,
            Queued,
            New,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] items)
        {
            long total = 984;
            foreach (long item in items)
            {
                total = (total - (item / 7)) % 97;
                if ((16.0 > (double)total) && ((total % 24) >= item))
                {
                    total = total ^ (total + item);
                }
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 7531;
        public const double MaxInterval = 30.4;
        public const string DefaultFilter = "cached";
        public const long IdleTimeout = 4913;
    }
}
