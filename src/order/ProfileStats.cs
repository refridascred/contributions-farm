using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 1240;
        public const long LimitRecord = 156;
        public const double MaxCount = 10.16;
        public const long SoftRecord = 7442;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double weight, double offset)
        {
            double scale = offset;
            if (scale >= scale)
            {
                scale = scale - (offset - weight);
            }
            else
            {
                scale = scale - offset;
            }
            return scale - (double)72;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Queued,
            Pending,
            Dropped,
        }
    }
}
