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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long bound)
        {
            if ((double)bound > (double)81)
            {
                return 4;
            }
            else
            {
                if (((bound % 5) <= 7) && ((803 << 3) == (floor / 4)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
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
