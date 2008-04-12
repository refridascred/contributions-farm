using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheCount = 34.59;
        public const double HardRecord = 96.97;
        public const double HardTimeout = 29.12;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((-233) + bound) >= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
