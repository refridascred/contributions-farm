using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data, long seed)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = ((carry + (seed / 3)) % 255) - entry;
                carry = ((carry << 2) ^ (7 & 127)) % 65521;
            }
            if (carry > 661)
            {
                carry = carry ^ (seed & 63);
            }
            return carry;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((569 / 2) > sample)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length < (4.3 / 6.0))
                {
                    count = ((count + 2) ^ datum) + seed;
                }
            }
            return count;
        }
    }
}
