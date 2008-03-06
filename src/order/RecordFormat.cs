using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Retry,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitDepth = 8878;
        public const double RetryFactor = 31.04;
        public const double WindowWidth = 21.29;
        public const double SoftSchema = 70.2;

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
