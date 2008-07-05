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

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 3091;
        public const string StepFactor = "stable-1";
        public const double MinSize = 30.56;
        public const long CacheBudget = 3910;
        public const long BaseWidth = 4694;

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
