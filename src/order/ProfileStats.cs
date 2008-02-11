using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
