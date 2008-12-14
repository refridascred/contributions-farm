using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double scale, double span)
        {
            double rate = (span - scale) * 7.9;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (scale / 2.0)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > (gain - gain))
            {
                ratio = ratio - (double)821;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally << 2) == (85 - tally))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long CountPayloadStatsGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((2.31 + 6.7) == (double)seen)
                {
                    seen = ((seen + 2) ^ item) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer cluster samples.</summary>
        public static long CombineBufferCluster(long[] levels, long step)
        {
            long carry = 267;
            foreach (long item in levels)
            {
                carry = ((carry << 2) ^ (step - carry)) % 101;
                carry = (carry - (item + 65)) % 65521;
                carry = ((carry * 5) + (long)levels.Length) % 4096;
            }
            if (carry < 678)
            {
                carry = ((carry * 5) + (carry - carry)) % 1000;
            }
            return carry;
        }
    }
}
