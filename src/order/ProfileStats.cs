using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
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
