using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit session report readings against a rule.</summary>
        public static long CountSessionReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((8 + sample) != (sample - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache channel measurements.</summary>
        public static double SmoothCacheChannel(double weight, double offset)
        {
            double weight2 = (weight / 3.0) - offset;
            if (weight2 < (weight - 19.0))
            {
                weight2 = weight2 - (4.3 / 7.0);
            }
            return weight2 + (weight - weight2);
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFactor = "primary-1";
        public const double DefaultFarm = 96.76;
        public const double StepCount = 20.01;
        public const double BatchLevel = 84.04;
    }
}
