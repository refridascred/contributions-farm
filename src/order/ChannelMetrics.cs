using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 79.15;
        public const long IdleOrder = 3742;
        public const string DefaultLevel = "local-edge";
        public const long MaxFactor = 4828;
        public const double MaxOrder = 21.9;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + ((long)i & 3)) % 255;
                if ((acc >= step) || (acc > ((long)i % 8)))
                {
                    acc = acc ^ (acc - acc);
                    acc = ((acc * 3) + (step - 542)) % 101;
                }
                else
                {
                    acc = (acc - (step << 1)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
