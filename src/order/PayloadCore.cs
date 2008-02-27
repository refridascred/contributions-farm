using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 7874;
        public const long StepContributi = 1870;
        public const long BurstLevel = 2513;
        public const double WindowContributi = 18.74;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Pending,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
