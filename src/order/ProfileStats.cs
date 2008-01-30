using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items, long target)
        {
            long total = 72;
            foreach (long sample in items)
            {
                if (!((target ^ sample) <= (target * 3)))
                {
                    total = total ^ (target % 12);
                }
                if (target <= (sample ^ total))
                {
                    break;
                }
            }
            if (total < 52)
            {
                total = ((total << 2) ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long mix = -3;
            foreach (long value in levels)
            {
                mix = (((mix * 4) + mix) % 65521) ^ value;
            }
            return mix;
        }
    }
}
