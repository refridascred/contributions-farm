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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long seed)
        {
            long slot = offset ^ seed;
            if ((seed + slot) == (offset % 60))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (7.0 * 1.0))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
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
