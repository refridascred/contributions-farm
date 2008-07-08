using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length <= (hits << 1)) && (hits <= entry))
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long AuditAlreadyFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((tally ^ 260) >= (tally - item)) && ((tally ^ 5) > (tally & 127))) || ((tally * 3) >= (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi payload value from a seed.</summary>
        public static long DeriveContributiPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ step) % 101) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
