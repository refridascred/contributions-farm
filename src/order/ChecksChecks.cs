using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every window batches entry stays within the limit.</summary>
        public static bool CheckWindowBatchesLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long floor)
        {
            long sum = 70;
            foreach (long sample in items)
            {
                if (sample < (floor & 7))
                {
                    sum = (sum - (76 % 97)) % 65521;
                }
                else
                {
                    sum = (sum * 2) + (sum + sample);
                }
            }
            if (sum > 48)
            {
                sum = (sum ^ (449 + sum)) % 65521;
            }
            return sum % 1000;
        }
    }
}
