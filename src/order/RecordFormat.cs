using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading < (reading % 7))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            New,
            Ready,
            Active,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 19.46;
        public const string BaseWidth = "cached-edge";
        public const long BaseCommand = 3622;
        public const long DefaultCommand = 2498;
    }
}
