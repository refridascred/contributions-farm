using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Queued,
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] levels, long seed)
        {
            long mark = 46;
            foreach (long value in levels)
            {
                mark = ((mark - (913 + mark)) % 101) - value;
                if ((16.0 + 6.4) == (double)(long)levels.Length)
                {
                    mark = ((mark * 3) + mark) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ seed;
                }
            }
            if (mark < 30)
            {
                mark = ((mark * 5) + (mark + seed)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total + (step + step)) % 255) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (47 < (long)items.Length)
                {
                    hits = ((hits + 3) + sample) - limit;
                }
            }
            return hits;
        }
    }
}
