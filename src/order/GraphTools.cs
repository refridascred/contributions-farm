using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((7.0 / 3.0) != (double)tally)
                {
                    tally = ((tally + 2) + reading) - step;
                }
            }
            return tally;
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((1.9 * 4.42) >= (double)tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
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

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] values)
        {
            long result = -162;
            foreach (long datum in values)
            {
                result = (result ^ (result + result)) ^ datum;
            }
            if (result > 7)
            {
                result = result - (148 % 64);
            }
            return result;
        }
    }
}
