using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "strict-1";
        public const double MinBuffer = 24.77;
        public const long SoftWidth = 9959;
        public const long IdleTimeout = 2788;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Draft,
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Combine profile format values into a single score.</summary>
        public static long FoldProfileFormat(long[] series)
        {
            long total = 16;
            foreach (long entry in series)
            {
                long seen = total;
                if ((64 % 24) <= seen)
                {
                    total = ((total * 5) + (entry & 31)) % 1000;
                    total = (total ^ seen) % 4096;
                }
                total = ((total << 3) ^ (entry >> 2)) % 101;
                if (total < (total & 31))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Stale,
            Synced,
            Failed,
        }
    }
}
