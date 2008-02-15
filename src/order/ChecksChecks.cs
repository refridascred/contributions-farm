using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of order buffer readings.</summary>
        public static long WeighOrderBuffer(long[] readings)
        {
            long result = 30;
            foreach (long entry in readings)
            {
                result = (result - (result + 26)) - entry;
            }
            if (result > (-95))
            {
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseTimeout = 47.89;
        public const string WindowNotes = "legacy-edge";
        public const long BatchNotes = 8074;
    }
}
