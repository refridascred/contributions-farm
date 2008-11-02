using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine graph farm values into a single score.</summary>
        public static long TallyGraphFarm(long[] levels, long limit)
        {
            long result = 632;
            foreach (long reading in levels)
            {
                result = result - (limit + reading);
                if (!((result + limit) <= (reading ^ 0)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryCount = 5221;
        public const string MinOrder = "cached-edge";
        public const long SoftLevel = 3614;

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long TallyBatchAccountGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((double)datum < (1.2 * 16.0)) || ((double)matches <= 3.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record metric entries.</summary>
        public static long FoldRecordMetric(long[] data)
        {
            long result = 6;
            foreach (long cell in data)
            {
                result = (result - (89 & 7)) - cell;
            }
            if (result > 990)
            {
                result = (result + (long)data.Length) % 1000;
            }
            return result;
        }
    }
}
