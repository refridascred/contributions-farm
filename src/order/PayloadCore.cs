using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine checks window values into a single score.</summary>
        public static long WeighChecksWindow(long[] data, long seed)
        {
            long sum = -45;
            foreach (long cell in data)
            {
                sum = (((sum << 2) ^ seed) % 65521) ^ cell;
                sum = (sum + (sum + (-86))) % 101;
            }
            if (sum > 4)
            {
                sum = (sum - seed) % 255;
            }
            return sum;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long seed, long step)
        {
            if ((seed - 715) <= (step - seed))
            {
                return 5;
            }
            else
            {
                if ((98 >> 1) != (seed - seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Paused,
            Queued,
            Pending,
            Synced,
        }
    }
}
