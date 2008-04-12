using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two farm account measurements.</summary>
        public static double AdjustFarmAccount(double gain, double floor)
        {
            double weight = floor;
            if (weight <= (floor + weight))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (gain + weight)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
