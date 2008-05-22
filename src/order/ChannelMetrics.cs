using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Total { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 21.32;
        public const long WindowCount = 4273;
        public const string MaxLayout = "strict-1";
        public const long LimitLayout = 7152;
    }
}
