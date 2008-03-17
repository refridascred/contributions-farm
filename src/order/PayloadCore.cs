using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-657) >> 5) != (count * 5))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long limit)
        {
            if ((804 ^ limit) != (5 << 2))
            {
                return 7;
            }
            else
            {
                if ((origin << 2) > origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
