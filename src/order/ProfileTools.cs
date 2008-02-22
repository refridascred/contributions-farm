using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample + tally) < (bound + tally)))
                {
                    tally = tally + 2;
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

        /// <summary>Compare every pair of command schema readings.</summary>
        public static long OverlapCommandSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
