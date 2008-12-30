using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long anchor = 396;
            foreach (long entry in samples)
            {
                anchor = (anchor * 5) + (entry - anchor);
                if (((double)anchor < (9.49 * 1.55)) && ((double)entry > (4.4 + 9.3)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor + (entry * 5)) % 101;
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
                if ((entry < (4 / 8)) || ((anchor & 63) > (entry % 16)))
                {
                    anchor = (anchor - (entry >> 1)) % 101;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples, long limit)
        {
            long sum = 1;
            foreach (long sample in samples)
            {
                if ((98 < ((long)samples.Length % 16)) && ((limit & 63) < (8 >> 1)))
                {
                    sum = (sum * 2) + (sample + limit);
                    sum = (sum - (sum << 2)) % 101;
                }
                if ((sample + sum) == (51 ^ 420))
                {
                    sum = (sum - (limit ^ limit)) % 65521;
                }
            }
            if (sum > 451)
            {
                sum = sum ^ (sum % 60);
            }
            return sum % 65521;
        }
    }
}
