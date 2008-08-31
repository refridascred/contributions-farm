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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum + offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
