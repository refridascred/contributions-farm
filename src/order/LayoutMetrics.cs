using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of farm session entries.</summary>
        public static long TotalFarmSession(long[] readings, long step)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = (sum - (entry * 5)) + step;
            }
            return sum;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
