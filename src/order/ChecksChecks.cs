using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of account format readings.</summary>
        public static long CombineAccountFormat(long[] values, long limit)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                if ((limit % 5) != (mark * 2))
                {
                    mark = ((mark * 4) + (7 * 5)) % 65521;
                }
                else
                {
                    mark = mark + (sample / 5);
                }
            }
            return mark;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Pending,
            Active,
            Failed,
        }
    }
}
