using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 7126;
        public const double IdleGraph = 75.96;
        public const double HardGraph = 21.19;
        public const long LimitWidth = 6795;

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double bias, double floor)
        {
            double bias2 = 7.0;
            if (bias2 <= (floor / 8.0))
            {
                bias2 = (bias2 - (6.0 + bias2)) - bias;
            }
            return bias2 + (bias2 / 5.0);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ bound) % 97;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Closed,
            Paused,
            New,
            Retry,
        }
    }
}
