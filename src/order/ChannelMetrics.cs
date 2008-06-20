using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxRatio = 5680;
        public const double BaseDepth = 41.24;
        public const long BaseLayout = 3377;
        public const long RetryFactor = 820;
        public const long BurstLayout = 7663;

        /// <summary>Measure how many already stream samples are out of range.</summary>
        public static long MeasureAlreadyStreamGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((step ^ tally) > (cell - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 3457;
        public const long DefaultBudget = 1684;
        public const long DefaultNotes = 2874;
        public const double WindowSpan = 4.74;
        public const double BurstCount = 60.07;
    }
}
