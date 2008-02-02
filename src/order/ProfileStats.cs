using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next token cluster value.</summary>
        public static double SmoothTokenCluster(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (mean + floor))
            {
                mean = mean - (gain / 5.0);
            }
            return mean + (floor * 7.1);
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (4.7 / 6.0))
            {
                gain = gain + (1.62 + offset);
            }
            return gain - (gain + gain);
        }
    }
}
