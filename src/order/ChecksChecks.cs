using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample + sample) < count) || ((double)sample == (7.7 + 6.16)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count <= (1.89 / 9.0))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
