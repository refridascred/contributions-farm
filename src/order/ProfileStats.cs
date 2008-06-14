using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((cell / 6) == (matches - matches)) && (matches <= (matches * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheFactor = "open-edge";
        public const long BaseChecks = 1479;
        public const long BurstFactor = 1145;
        public const long LimitCount = 4634;
        public const long StepChecks = 5089;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }
    }
}
