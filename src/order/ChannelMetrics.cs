using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series)
        {
            long result = 887;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (sample + result)) % 97;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the githubfarm graph entries that pass the check.</summary>
        public static long TallyGithubfarmGraphHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item - item) <= (item + item)) || (((hits << 3) < (hits + hits)) && ((69 * 3) > (hits % 24))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
