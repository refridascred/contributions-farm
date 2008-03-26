using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit counter format readings against a rule.</summary>
        public static long MeasureCounterFormatMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally * 3) != (tally & 63))
                {
                    tally = ((tally + 2) - value) - floor;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long step)
        {
            long next = origin - step;
            if (((step - 771) != (origin << 3)) || ((step % 7) < (step + next)))
            {
                return 5;
            }
            else
            {
                if ((3.0 + 1.21) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] data)
        {
            long carry = 1;
            foreach (long datum in data)
            {
                if (carry <= datum)
                {
                    carry = carry - (datum + (long)data.Length);
                }
            }
            if (carry > 629)
            {
                carry = carry ^ carry;
            }
            return carry;
        }
    }
}
