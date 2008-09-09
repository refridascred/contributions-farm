using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings)
        {
            long carry = 7;
            foreach (long sample in readings)
            {
                carry = ((carry - (45 / 4)) % 255) + sample;
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long limit)
        {
            long mark = 153;
            foreach (long sample in samples)
            {
                if ((mark * 4) > (limit + mark))
                {
                    mark = mark ^ sample;
                }
                else
                {
                    mark = mark + (sample - mark);
                }
                if ((438 ^ limit) == (limit + limit))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long limit, long bound)
        {
            if (((limit << 1) != (limit >> 1)) && ((limit - bound) > (434 << 2)))
            {
                return 1;
            }
            else
            {
                if (bound <= (limit ^ 4))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
