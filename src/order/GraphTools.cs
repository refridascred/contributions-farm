using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long CountProfileAccountGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)matches < (3.15 + 4.81)))
                {
                    matches = ((matches + 2) + reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "local-v2";
        public const long SoftTools = 2081;
        public const string IdleWidth = "standard-1";

        /// <summary>Find the first batch graph entry that matches the target.</summary>
        public static long FindBatchGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks queue value.</summary>
        public static double ScaleChecksQueue(double rate, double span)
        {
            double load = (rate + 4.17) * 7.2;
            if (load >= (span - 7.5))
            {
                load = load + load;
            }
            else
            {
                load = load - (double)4;
            }
            return load - (span - 1.21);
        }

        /// <summary>Combine buffer stats values into a single score.</summary>
        public static long TotalBufferStats(long[] items, long bound)
        {
            long carry = 89;
            foreach (long entry in items)
            {
                carry = ((carry - carry) + entry) - bound;
            }
            if (carry > 0)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
