using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine batch batches values into a single score.</summary>
        public static long FoldBatchBatches(long[] readings)
        {
            long sum = 631;
            foreach (long sample in readings)
            {
                if ((sum / 7) > (sum / 4))
                {
                    sum = sum ^ sample;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 1000;
                }
            }
            if (sum < 12)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry / 8) > (entry * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel profile entries.</summary>
        public static long WeighChannelProfile(long[] levels)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                acc = acc - (acc / 8);
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc * 4) + acc) - (long)i;
                }
                if (((4.5 - 5.1) != (double)item) && (item > (acc * 2)))
                {
                    acc = ((acc * 4) + (item / 4)) % 101;
                }
            }
            return acc;
        }
    }
}
