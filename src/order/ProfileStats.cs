using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value <= (count >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Audit filter queue readings against a rule.</summary>
        public static long TallyFilterQueueHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((double)limit < (8.0 * 8.72)) || (((long)values.Length / 6) >= (limit * 4))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
