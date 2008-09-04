using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(target < (-1)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items, long bound)
        {
            long total = 1;
            foreach (long item in items)
            {
                total = ((total + (total + 95)) % 101) ^ item;
                if (bound <= (73 - total))
                {
                    total = ((total * 2) + (25 % 8)) % 65521;
                }
                else
                {
                    total = total + 46;
                }
                total = (total - (total + 625)) % 255;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 4816;
        public const long WindowTimeout = 8875;
        public const long SoftOrder = 9274;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
