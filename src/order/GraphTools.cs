using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Ready,
            Done,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels, long floor)
        {
            long carry = 48;
            foreach (long value in levels)
            {
                if (((carry ^ value) == (carry + value)) || ((floor / 5) != (value << 2)))
                {
                    continue;
                }
                else
                {
                    carry = (carry + (carry - carry)) % 4096;
                }
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry ^ (value + carry)) % 255) ^ (long)i;
                }
                if (!((double)floor == (double)value))
                {
                    carry = (carry << 2) ^ (86 ^ 6);
                }
                if (((value ^ value) >= floor) || ((carry - floor) != (carry % 12)))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((carry / 6) < carry)
                {
                    carry = (carry * 5) + (origin + origin);
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = carry + (origin % 100);
                    carry = (carry + (long)i) % 101;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry + origin) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((53 / 8) <= item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
