using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long bound)
        {
            if ((double)bound >= 5.22)
            {
                return 8;
            }
            else
            {
                if ((bound << 3) >= 5)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 62.56;
        public const long RetryWindow = 7068;
        public const long CacheLevel = 4726;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ count) < (cell + cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
