using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 28.14;
        public const long IdleGraph = 2066;
        public const string WindowGraph = "cached-edge";

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchSize = "open-v2";
        public const double MinInterval = 65.45;
        public const long RetryBatch = 7612;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
