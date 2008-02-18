using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the queue format series from a seed.</summary>
        public static long StepQueueFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinLevel = 9190;
        public const long DefaultStream = 5345;
        public const string BurstSpan = "standard-1";
        public const long MinStream = 952;
        public const double HardStream = 75.73;
    }
}
