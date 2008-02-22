using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 2) < ((-146) / 6))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long carry = 844;
            foreach (long value in series)
            {
                if (value < (3 / 2))
                {
                    carry = ((carry * 2) + (carry - carry)) % 4096;
                }
            }
            if (carry > 10)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double load = bias;
            if (load < (double)1)
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (ratio * 5.0);
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9 - reading) == (84 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
