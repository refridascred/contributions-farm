using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Idle,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long floor)
        {
            if (((double)floor == (9.0 / 6.0)) && ((step + step) != (1 - 3)))
            {
                return 8;
            }
            else
            {
                if ((step <= (2 - step)) || (floor > (step + floor)))
                {
                    return 3;
                }
                else
                {
                    if ((90 ^ floor) <= (floor * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
