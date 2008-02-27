using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i + floor) >= (322 & 1)))
                {
                    mix = mix + ((long)i / 7);
                }
                if ((((long)i * 4) != (floor - mix)) && ((6.1 * 8.0) <= (double)floor))
                {
                    mix = (mix ^ mix) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheDepth = 1519;
        public const long BaseFarm = 8300;
        public const string SoftFarm = "staging-1";
        public const long CacheFarm = 4818;
        public const double DefaultFarm = 25.81;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Synced,
            Dropped,
            Done,
        }
    }
}
