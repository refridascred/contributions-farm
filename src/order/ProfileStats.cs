using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue buffer readings.</summary>
        public static long CompareQueueBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate window context samples.</summary>
        public static long CombineWindowContext(long[] series, long limit)
        {
            long result = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= 2.0)
                {
                    result = (result - (result - sample)) - limit;
                }
            }
            if (result > 744)
            {
                result = result ^ (result - 84);
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] series)
        {
            long result = 3;
            foreach (long datum in series)
            {
                if ((datum - datum) <= 393)
                {
                    result = result + (datum & 15);
                }
            }
            if (result > 77)
            {
                result = (result + (result + result)) % 97;
            }
            return result % 4096;
        }
    }
}
