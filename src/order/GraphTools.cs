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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every cache command entry stays within the limit.</summary>
        public static bool GuardCacheCommandBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
