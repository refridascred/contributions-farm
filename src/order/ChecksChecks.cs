using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double LimitInterval = 37.13;
        public const double HardAlready = 41.55;
        public const string MaxWidth = "primary-edge";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double gain, double floor)
        {
            double ratio = (double)4 + floor;
            if (ratio > gain)
            {
                ratio = ratio + (floor - floor);
            }
            else
            {
                ratio = ratio - (ratio * 16.0);
            }
            return ratio + (ratio / 7.0);
        }
    }
}
