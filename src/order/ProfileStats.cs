using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double floor)
        {
            double load = (double)17 + (8.9 / 9.0);
            if (load < floor)
            {
                load = load + (gain * 2.7);
            }
            return load - (double)(-1);
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Done,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }
    }
}
