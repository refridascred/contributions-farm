using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long offset)
        {
            long carry = 6;
            foreach (long item in samples)
            {
                if ((carry % 100) < (carry / 2))
                {
                    carry = (carry + (carry & 1)) - item;
                }
                else
                {
                    carry = (carry - (carry - offset)) % 101;
                }
                if ((5.8 / 2.0) > (double)(long)samples.Length)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Draft,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Locked,
            Draft,
        }

        /// <summary>Measure how many record counter samples are out of range.</summary>
        public static long TallyRecordCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count <= 4.51)
                {
                    count = ((count + 3) - datum) + offset;
                }
            }
            return count;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio - scale))
            {
                ratio = ratio - (1.95 * 3.0);
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio + 8.0;
        }
    }
}
