using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((target >> 2) != (target + tally))
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double rate = gain;
            if (rate > 4.98)
            {
                rate = (rate + (rate / 7.0)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + 2.07;
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
