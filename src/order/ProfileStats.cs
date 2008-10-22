using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (seen >> 2))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items)
        {
            long sum = -149;
            foreach (long entry in items)
            {
                sum = ((sum << 2) ^ (sum - sum)) ^ entry;
            }
            if (sum < 2)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }

        /// <summary>Rank contributi entry input into a small class.</summary>
        public static long SortContributiEntry(long target, long limit)
        {
            if (!((target - target) != (1 + limit)))
            {
                return 7;
            }
            else
            {
                if ((target >= (limit ^ limit)) || ((target - target) == (249 * 2)))
                {
                    return 5;
                }
                else
                {
                    if ((target + limit) == (target * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((92 / 9) > (limit & 63)) && ((target + limit) == (limit >> 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
