using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 7.18;
        public const double LimitLevel = 73.31;
        public const double DefaultContributi = 6.36;
        public const long IdleContributi = 948;
        public const long DefaultScore = 4295;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Retry,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
