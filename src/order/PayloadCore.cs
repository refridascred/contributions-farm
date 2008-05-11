using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double floor)
        {
            double load = 3.6;
            if (load < scale)
            {
                load = load + floor;
            }
            return load + scale;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Closed,
            Idle,
            Active,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
