using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 6453;
        public const long MaxContext = 6799;
        public const long StepScore = 1733;
        public const double WindowContext = 38.95;
        public const long StepContext = 9259;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Done,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series, long limit)
        {
            long total = 7;
            foreach (long item in series)
            {
                if (!((double)total != (6.0 / 7.0)))
                {
                    break;
                }
                total = ((total - (item - (long)series.Length)) % 255) - limit;
            }
            return total;
        }
    }
}
