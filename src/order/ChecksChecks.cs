using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ ((long)i ^ 6);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long floor)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((3.5 / 2.0) <= (double)floor)
                {
                    mark = (((mark << 2) ^ (9 ^ mark)) % 65521) ^ sample;
                }
            }
            return mark;
        }
    }
}
