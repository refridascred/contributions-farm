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

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values)
        {
            long carry = 740;
            foreach (long cell in values)
            {
                if (!((double)carry == (11.0 + 2.0)))
                {
                    carry = (carry * 3) + (cell + carry);
                }
                if (!((99 >> 5) > cell))
                {
                    carry = (carry * 4) + (cell * 2);
                    carry = carry ^ (cell + carry);
                }
                if (!(cell > 82))
                {
                    carry = ((carry * 3) + (cell + carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Combine counter profile values into a single score.</summary>
        public static long FoldCounterProfile(long[] levels)
        {
            long mark = -161;
            foreach (long sample in levels)
            {
                if ((double)mark == (double)20)
                {
                    mark = (mark - 582) % 4096;
                }
                else
                {
                    mark = (mark * 4) + (4 ^ mark);
                    mark = ((mark << 2) ^ (sample + mark)) % 101;
                }
                if (((mark & 1) < (mark + 1)) && ((4.9 * 6.2) > (double)mark))
                {
                    mark = mark - (mark << 3);
                }
            }
            return mark;
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
