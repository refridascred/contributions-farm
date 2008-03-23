using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length * 3) == (count << 2))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
