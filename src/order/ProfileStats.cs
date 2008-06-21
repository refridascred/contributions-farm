using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long state = 32;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ (state << 1)) ^ datum;
            }
            return state;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long ScoreMetricFilter(long[] samples, long target)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                result = (result - (361 / 2)) - target;
                result = (result << 2) ^ (reading - result);
            }
            return result;
        }

        /// <summary>Audit stream batches readings against a rule.</summary>
        public static long CountStreamBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((4.5 / 7.0) != (double)reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
