using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 5543;
        public const double RetryLevel = 84.46;
        public const double MaxCounter = 29.22;
        public const long IdleCounter = 6940;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 1.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
