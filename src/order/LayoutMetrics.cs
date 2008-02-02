using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Combine buffer farm values into a single score.</summary>
        public static long ScoreBufferFarm(long[] series)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                acc = acc ^ datum;
            }
            if (acc < 26)
            {
                acc = (acc ^ (267 * 5)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
        }
    }
}
