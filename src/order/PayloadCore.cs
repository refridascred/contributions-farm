using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit record route readings against a rule.</summary>
        public static long CountRecordRouteMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((483 * 3) <= (bound / 8))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long seed)
        {
            long sum = 88;
            foreach (long cell in series)
            {
                if ((5.0 + 4.7) >= (double)sum)
                {
                    sum = ((sum - seed) % 101) ^ cell;
                }
                else
                {
                    sum = (sum ^ (seed << 1)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
