using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Locked,
            Queued,
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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long step)
        {
            if (((1.4 - 9.3) < (double)step) || ((bound + step) < 0))
            {
                return 4;
            }
            else
            {
                if ((bound & 7) > (step >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound <= (15.0 - 2.15))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step >= (step + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
