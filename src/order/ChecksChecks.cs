using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "legacy-edge";
        public const long MinEditor = 3718;
        public const long WindowEditor = 3997;

        /// <summary>Check that every counter checks entry stays within the limit.</summary>
        public static bool ValidateCounterChecksLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
