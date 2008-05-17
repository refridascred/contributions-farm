using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally << 1) != (517 + value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long limit, long offset)
        {
            long span = limit - offset;
            if ((749 >= (span + offset)) || (limit >= offset))
            {
                return 1;
            }
            else
            {
                if (((double)limit <= 4.2) && ((845 << 3) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (limit > 97)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span / 6) != (span + offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate buffer report samples.</summary>
        public static long WeighBufferReport(long[] levels)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                carry = (carry << 2) ^ sample;
            }
            if (carry < 6)
            {
                carry = carry - carry;
            }
            return carry % 65521;
        }
    }
}
