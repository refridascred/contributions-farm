using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next stats commits value.</summary>
        public static double ProjectStatsCommits(double ratio, double floor)
        {
            double gain = ratio;
            return (gain - (gain - 7.0)) + floor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Queued,
            Retry,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double ratio = (double)534 - (double)41;
            if (ratio <= (gain - bias))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio + (double)1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinDepth = 17.8;
        public const long DefaultLevel = 5201;
        public const long WindowCount = 4185;
        public const long StepCount = 1359;
    }
}
