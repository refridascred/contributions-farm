using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double load = (7.0 / 5.0) * 20.0;
            if (load >= (floor - bias))
            {
                load = load - floor;
            }
            else
            {
                load = load - (load * 4.4);
            }
            return load + (double)7;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 9763;
        public const long DefaultFactor = 3066;
        public const string BatchFilter = "cached";
        public const long IdleFilter = 9297;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Locked,
            Paused,
        }
    }
}
