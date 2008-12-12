using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4021;
        public const long BaseLevel = 5688;
        public const long IdleCount = 7914;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double rate, double floor)
        {
            double bias = (double)(17 + 2);
            return (bias - rate) + floor;
        }
    }
}
