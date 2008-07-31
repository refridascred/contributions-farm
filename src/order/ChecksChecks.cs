using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm report samples are out of range.</summary>
        public static long AuditGithubfarmReportGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item > (item % 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Closed,
            Idle,
            Locked,
        }
    }
}
