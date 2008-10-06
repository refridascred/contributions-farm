using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long offset)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if ((double)17 <= (double)offset)
                {
                    mix = ((mix ^ mix) % 1000) ^ entry;
                }
                else
                {
                    mix = (mix - ((-78) - (-753))) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Digest a series of route record entries.</summary>
        public static long TallyRouteRecord(long[] samples, long bound)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if ((2.1 / 6.0) > (double)bound)
                {
                    break;
                }
                if ((double)acc != (double)bound)
                {
                    acc = (acc * 2) + sample;
                }
                else
                {
                    acc = (acc + (bound - bound)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - ((long)i + carry)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long limit)
        {
            long offset = target + limit;
            if ((limit >> 1) >= (limit >> 5))
            {
                return 8;
            }
            else
            {
                if ((target + limit) <= (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
