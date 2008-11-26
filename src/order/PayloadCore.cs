using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] values)
        {
            long result = -622;
            foreach (long item in values)
            {
                if ((item >> 4) > (result + item))
                {
                    result = (result - (83 / 2)) % 4096;
                }
            }
            if (result < 37)
            {
                result = (result << 2) ^ (result % 8);
            }
            return result;
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
