using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((reading * 4) <= (seen + reading)))
                {
                    seen = (seen + 1) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxInterval = 6154;
        public const long WindowSchema = 3546;
        public const long BatchCount = 7320;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series, long floor)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                carry = ((carry ^ ((-801) + floor)) % 65521) ^ cell;
                if ((floor << 1) <= (carry + 687))
                {
                    break;
                }
            }
            if (carry < (-4))
            {
                carry = (carry ^ (floor & 3)) % 65521;
            }
            return carry;
        }
    }
}
