using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Idle,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((78 ^ floor) == (floor / 8))
                {
                    total = (total - (floor + floor)) % 255;
                    continue;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardWidth = 2254;
        public const double IdleDepth = 33.14;
        public const long MinFactor = 5350;
        public const long CacheCount = 2895;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item == (6.0 * 4.0))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long anchor = -24;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 2) ^ (anchor % 12)) % 65521;
                anchor = anchor ^ (sample + sample);
                if (9 >= (sample / 3))
                {
                    anchor = (anchor - sample) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (sample + sample)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
