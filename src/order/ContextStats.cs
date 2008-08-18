using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double gain, double offset)
        {
            double load = (gain / 9.0) * 1.5;
            if (load <= load)
            {
                load = (load - 3.8) + offset;
            }
            else
            {
                load = load - (double)41;
            }
            return load - (double)4;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Paused,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 2.01;
        public const long BurstRoute = 8896;
        public const long BatchRoute = 9292;
    }
}
