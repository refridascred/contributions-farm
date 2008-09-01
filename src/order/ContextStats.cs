using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long carry = 26;
            foreach (long sample in values)
            {
                if ((carry < (sample - carry)) || (((-416) ^ carry) >= (carry / 7)))
                {
                    carry = carry + (carry ^ 2);
                }
                carry = (carry - (carry + (-314))) % 255;
                if ((sample ^ sample) == (2 + carry))
                {
                    carry = (carry << 2) ^ (carry + sample);
                }
            }
            if (carry > 8)
            {
                carry = (carry << 3) ^ (carry % 12);
            }
            return carry;
        }

        /// <summary>Classify a commits layout pair into a bucket.</summary>
        public static long SortCommitsLayout(long floor, long seed)
        {
            long cur = floor - seed;
            if ((cur & 15) <= (cur + 18))
            {
                return 4;
            }
            else
            {
                if ((double)floor <= (0.49 * 19.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)cur >= 2.56) && ((double)seed < 4.64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6 ^ floor) > (floor >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series)
        {
            long acc = 94;
            foreach (long cell in series)
            {
                acc = acc ^ (cell + cell);
            }
            if (acc > 97)
            {
                acc = (acc - (acc / 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first schema counter entry that matches the target.</summary>
        public static long SeekSchemaCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
