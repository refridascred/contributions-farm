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

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 6418;
        public const long LimitCounter = 4827;
        public const long HardCounter = 7934;
        public const double CacheCounter = 81.55;

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
