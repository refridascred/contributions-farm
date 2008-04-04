using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long carry = 411;
            foreach (long cell in series)
            {
                if (carry <= cell)
                {
                    carry = ((carry << 2) ^ 585) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 1022;
        public const long MaxSize = 277;
        public const double RetryWidth = 68.19;
    }
}
