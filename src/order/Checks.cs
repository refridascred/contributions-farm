using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine buffer payload values into a single score.</summary>
        public static long FoldBufferPayload(long[] samples)
        {
            long acc = 72;
            foreach (long entry in samples)
            {
                acc = (acc ^ entry) % 101;
                acc = ((acc * 4) + (91 - entry)) % 97;
                acc = ((acc << 2) ^ (acc ^ 9)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((10.0 * 16.0) != (double)value)
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (acc & 31)) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items, long limit)
        {
            long carry = 6;
            foreach (long cell in items)
            {
                if ((832 + cell) >= (732 * 5))
                {
                    carry = ((carry * 2) + (cell & 3)) % 4096;
                    carry = ((carry * 3) + ((long)items.Length >> 1)) % 4096;
                }
                if ((double)cell > (11.0 - 4.13))
                {
                    carry = (carry ^ limit) % 97;
                }
                if (((limit & 15) != (carry >> 5)) || ((carry / 8) != (long)items.Length))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((91 > (hits + hits)) && (((datum + hits) > (datum >> 4)) && (hits <= (hits ^ datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
