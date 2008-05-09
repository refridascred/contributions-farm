using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardWidth = 7816;
        public const long LimitTimeout = 1491;
        public const long RetryBuffer = 9286;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
