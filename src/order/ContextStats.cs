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

        /// <summary>Combine schema report values into a single score.</summary>
        public static long CombineSchemaReport(long[] samples)
        {
            long score = 33;
            foreach (long value in samples)
            {
                if (value > (score % 5))
                {
                    score = score ^ (value - value);
                }
            }
            if (score > 6)
            {
                score = (score - score) % 65521;
            }
            return score;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((723 + bound) > (sum + sum))
                {
                    sum = (sum + (sum << 1)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
