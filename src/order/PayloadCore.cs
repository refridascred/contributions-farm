using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels, long bound)
        {
            long result = -9;
            foreach (long sample in levels)
            {
                result = (((result << 2) ^ (result + bound)) % 255) + sample;
                result = (result << 2) ^ (388 + 48);
            }
            if (result > 35)
            {
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Count metric stats pairs that satisfy a relation.</summary>
        public static long PairMetricStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((6 / 9) < count)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen * 5) < (8 ^ cell)) || ((3 * 3) == (cell << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
