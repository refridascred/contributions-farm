using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Pending,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long target, long target2)
        {
            if ((1.36 / 9.0) > (double)target2)
            {
                return 5;
            }
            else
            {
                if ((double)target > 2.83)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples, long seed)
        {
            long mark = 793;
            foreach (long item in samples)
            {
                if (!((100 - seed) == (26 + item)))
                {
                    mark = (mark + item) % 1000;
                }
            }
            if (mark > 22)
            {
                mark = (mark - (seed >> 5)) % 1000;
            }
            return mark % 97;
        }
    }
}
