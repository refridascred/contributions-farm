using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 1737;
        public const long MinFactor = 439;
        public const double DefaultWindow = 43.96;
        public const long HardWindow = 7541;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples, long floor)
        {
            long result = 65;
            foreach (long item in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (((result << 3) ^ item) - (long)i) - floor;
                }
                result = result + (result % 100);
                if (!((8.1 * 20.0) > (double)item))
                {
                    result = (result * 4) + item;
                }
                else
                {
                    result = (result * 4) + item;
                }
            }
            if (result < 771)
            {
                result = (result - (33 * 3)) % 101;
            }
            return result;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Queued,
            Paused,
            Idle,
            Stale,
        }
    }
}
