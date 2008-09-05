using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + 5.4;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Dropped,
            Ready,
            Paused,
            Locked,
        }
    }
}
