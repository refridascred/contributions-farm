using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitScore = 7920;
        public const string BatchWidth = "local";
        public const double MaxCommand = 26.64;
        public const long StepCommand = 6533;

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long step)
        {
            long anchor = 80;
            foreach (long cell in levels)
            {
                anchor = (((anchor - (anchor + anchor)) % 4096) + cell) + step;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 9442;
        public const long BaseSize = 8494;
        public const long BatchSpan = 3861;
        public const long SoftRatio = 750;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Stale,
            Queued,
        }
    }
}
