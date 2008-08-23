using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7664;
        public const long MinContext = 1693;
        public const long IdleContext = 3894;
        public const long CacheContext = 8534;

        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long DigestGithubfarmProfile(long[] samples, long origin)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = (acc + (21 - acc)) - entry;
                if (!((origin & 63) >= acc))
                {
                    break;
                }
            }
            if (acc > 591)
            {
                acc = acc ^ (acc ^ origin);
            }
            return acc;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long total = 40;
            foreach (long entry in data)
            {
                total = (total ^ total) + entry;
                total = total ^ (total + 534);
            }
            return total % 4096;
        }
    }
}
