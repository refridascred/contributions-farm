using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultInterval = "open-edge";
        public const long DefaultFactor = 4918;
        public const string HardLevel = "cached";
        public const string WindowLayout = "primary-1";

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = (gain + floor) - weight;
            }
            return gain - (11.0 * 0.18);
        }
    }
}
