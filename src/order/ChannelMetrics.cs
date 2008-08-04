using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSize = 2089;
        public const long BurstBudget = 6070;
        public const long WindowProfile = 8955;
        public const long IdleProfile = 2950;
        public const double MinCount = 8.55;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + 68) != (count >> 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
