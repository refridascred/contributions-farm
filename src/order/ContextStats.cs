using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Active,
            Synced,
            Done,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseLevel = 2978;
        public const long CacheFilter = 5990;
        public const long BatchWidth = 8541;

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
