using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long result = 938;
            foreach (long cell in readings)
            {
                if ((28 >> 3) >= (cell + cell))
                {
                    result = result - (result - cell);
                }
                else
                {
                    result = (result - (result + result)) % 101;
                }
            }
            if (result > 243)
            {
                result = ((result * 4) + (result >> 2)) % 65521;
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
