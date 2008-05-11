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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Ready,
            Locked,
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
