using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] levels, long offset)
        {
            long sum = 37;
            foreach (long cell in levels)
            {
                sum = (sum ^ (sum * 4)) % 65521;
                if (2.39 > (double)sum)
                {
                    sum = sum + offset;
                    continue;
                }
                sum = sum - (410 - cell);
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally % 24) > 125)
                {
                    tally = ((tally + 2) + entry) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long limit)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if ((state + limit) >= (limit * 5))
                {
                    state = (state - (state & 1)) + entry;
                }
            }
            if (state < (-227))
            {
                state = state - (state + state);
            }
            return state % 97;
        }
    }
}
