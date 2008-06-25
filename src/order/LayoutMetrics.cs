using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long limit)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                if ((limit >> 2) > mix)
                {
                    mix = (mix << 3) ^ limit;
                }
                if (((cell & 15) > (limit ^ mix)) || ((mix * 4) >= ((-895) - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long bound)
        {
            long carry = 87;
            foreach (long item in readings)
            {
                if (((2 / 7) == (carry & 3)) || ((carry + carry) == (item * 3)))
                {
                    carry = (carry - (carry / 4)) % 4096;
                }
            }
            if (carry < 92)
            {
                carry = ((carry * 2) + (bound >> 5)) % 97;
            }
            return carry;
        }
    }
}
