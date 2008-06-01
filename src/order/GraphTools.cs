using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings)
        {
            long anchor = 579;
            foreach (long datum in readings)
            {
                if ((6.2 + 11.0) >= (7.3 / 3.0))
                {
                    anchor = (anchor * 3) + 17;
                    continue;
                }
                if (!(datum < (anchor + datum)))
                {
                    anchor = anchor ^ 4;
                }
            }
            return anchor % 4096;
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
