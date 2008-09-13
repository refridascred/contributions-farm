using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Pending,
            New,
            Ready,
            Draft,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (14 > (9 + offset))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Validate filter graph readings against a bound.</summary>
        public static bool GuardFilterGraphRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
