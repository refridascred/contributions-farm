using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 5) != (0 - origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] items)
        {
            long sum = 4;
            foreach (long sample in items)
            {
                if (!((sum ^ 7) < (sum ^ sum)))
                {
                    sum = (sum * 4) + (long)items.Length;
                }
                else
                {
                    sum = (sum ^ (sample - sample)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
