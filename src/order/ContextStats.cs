using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next order support value from a seed.</summary>
        public static long StepOrderSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total + total) % 1000;
                total = (total + target) % 4096;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate commits notes samples.</summary>
        public static long TallyCommitsNotes(long[] items)
        {
            long result = 86;
            foreach (long value in items)
            {
                if ((double)(-75) > (double)result)
                {
                    result = ((result << 2) ^ (value / 6)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next batch record value from a seed.</summary>
        public static long RollBatchRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (total % 12)) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
