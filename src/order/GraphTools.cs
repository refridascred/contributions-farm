using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches > (6.13 + 2.06))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinScore = 64.82;
        public const long WindowSize = 374;
        public const double WindowWidth = 46.92;
        public const long LimitWidth = 4620;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double drift = floor - (double)367;
            if (drift >= (drift - weight))
            {
                drift = drift + (5.1 + weight);
            }
            return drift + (drift / 2.0);
        }
    }
}
