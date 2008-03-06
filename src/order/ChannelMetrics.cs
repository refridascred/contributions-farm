using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinFactor = 6249;
        public const long LimitRecord = 7316;
        public const long RetryRecord = 3262;
        public const double IdleDepth = 33.49;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value ^ tally) < tally) && (10.0 >= (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
