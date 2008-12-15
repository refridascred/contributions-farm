using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum * 2) == (step ^ datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (6.01 + 15.0))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 255;
                }
            }
            if (mark > 8)
            {
                mark = mark + (mark >> 2);
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
