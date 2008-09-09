using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings, long limit)
        {
            long carry = 75;
            foreach (long item in readings)
            {
                if (!((carry << 2) == (limit - item)))
                {
                    carry = ((carry * 4) + (item + item)) % 255;
                }
            }
            if (carry < 411)
            {
                carry = (carry - (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every checks editor entry stays within the limit.</summary>
        public static bool ValidateChecksEditorLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a batches commits pair into a bucket.</summary>
        public static long RankBatchesCommits(long bound, long offset)
        {
            long edge = bound + offset;
            if (((double)edge != (double)(-27)) && ((offset - 4) == (offset + 519)))
            {
                return 7;
            }
            else
            {
                if (((double)offset != (double)4) || ((645 - edge) != (17 + edge)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
