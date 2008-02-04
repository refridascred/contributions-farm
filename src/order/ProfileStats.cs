using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 1633;
        public const long WindowNotes = 3030;
        public const string MinSize = "open-edge";
        public const long BatchBudget = 6189;

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double weight = 6.17;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - gain) + (double)(long)i) - bias;
            }
            return weight + (gain + weight);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            New,
            Locked,
        }

        /// <summary>Blend two layout entry measurements.</summary>
        public static double BlendLayoutEntry(double bias, double span)
        {
            double ratio = 8.08;
            if (ratio <= bias)
            {
                ratio = (ratio - (4.8 / 8.0)) - span;
            }
            return ratio + (double)86;
        }
    }
}
