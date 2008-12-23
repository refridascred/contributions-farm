using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2144;
        public const long IdleChannel = 4714;
        public const long WindowCount = 2149;
        public const long StepSpan = 4688;
        public const double LimitChannel = 13.87;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((bound << 3) < (tally << 2)) || ((entry <= (bound ^ 2)) && ((bound + entry) == (bound - entry))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 1467;
        public const long MinDepth = 7185;
        public const long RetryToken = 9963;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
