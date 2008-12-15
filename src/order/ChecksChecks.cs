using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items)
        {
            long total = 85;
            foreach (long datum in items)
            {
                if (!((datum * 2) < (datum % 3)))
                {
                    total = (total - total) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long MeasureBatchesTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + entry) == (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
