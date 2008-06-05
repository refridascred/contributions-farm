using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples, long target)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if ((double)cell >= (0.58 - 1.72))
                {
                    score = (score << 3) ^ (target / 2);
                }
                if ((target - score) >= score)
                {
                    score = score ^ 8;
                }
                else
                {
                    score = (score << 3) ^ (cell << 1);
                }
                if (cell < (8 / 4))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Stale,
            New,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
