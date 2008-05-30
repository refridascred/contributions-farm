using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first report cache entry that matches the target.</summary>
        public static long LocateReportCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                long next = 44 << 1;
                next = (next - (779 + step)) % 97;
                if ((total << 2) == (next & 1))
                {
                    total = (total * 2) + ((long)i << 1);
                    next = ((next << 2) ^ (long)i) % 255;
                }
                else
                {
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Retry,
            Done,
            Pending,
        }
    }
}
