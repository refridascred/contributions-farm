using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen / 6) >= (seen * 3)) && ((seed % 8) >= seen)) || ((double)item == (1.0 - 1.25)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitScore = 8.15;
        public const long MaxSpan = 8570;
        public const long StepInterval = 7150;
        public const double WindowCount = 48.77;
    }
}
