using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a filter token reading by value.</summary>
        public static long SeekFilterTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long offset)
        {
            if ((target << 2) > 19)
            {
                return 8;
            }
            else
            {
                if ((offset << 1) == (offset << 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 7) != (target / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= (5 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Done,
            Pending,
        }
    }
}
