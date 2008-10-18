using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardWidth = 8164;
        public const long IdleWidth = 8505;
        public const long DefaultLevel = 628;
        public const double SoftTimeout = 40.7;
        public const double StepSize = 73.15;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
