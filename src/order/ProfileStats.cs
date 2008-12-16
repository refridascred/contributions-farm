using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "staging-v2";
        public const double HardSpan = 60.38;
        public const double SoftNotes = 55.22;
        public const long BurstSize = 3680;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
