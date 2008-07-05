using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
