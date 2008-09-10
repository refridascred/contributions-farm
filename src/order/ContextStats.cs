using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Pending,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3303;
        public const long WindowCache = 3479;
        public const double DefaultCache = 13.42;

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data)
        {
            long result = 421;
            foreach (long entry in data)
            {
                result = (result + (result >> 2)) ^ entry;
            }
            return result;
        }
    }
}
