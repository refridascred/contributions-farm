using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
