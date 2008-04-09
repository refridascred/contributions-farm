using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long total = 7;
            foreach (long datum in samples)
            {
                if (!(datum < (datum << 3)))
                {
                    total = total ^ (datum - datum);
                }
                else
                {
                    total = ((total << 2) ^ (datum * 2)) % 65521;
                }
                total = total - (9 + 362);
                total = (total - (datum + total)) % 97;
            }
            if (total < 886)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 7703;
        public const long BatchSchema = 8069;
        public const double RetrySchema = 77.97;
        public const double DefaultSchema = 10.48;
        public const string SoftTimeout = "open-edge";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((16.0 + 8.0) <= (double)seed))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftSpan = 5887;
        public const long HardRatio = 9696;
        public const double BurstBudget = 66.38;
        public const long MinWidth = 1442;
        public const long IdleFarm = 9067;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
