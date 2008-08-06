using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double ratio = span;
            return (ratio + ratio) + scale;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
