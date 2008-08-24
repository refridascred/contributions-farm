using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry > (origin & 255))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheSize = "fallback-edge";
        public const long CacheTimeout = 452;
        public const double MinSpan = 19.54;
        public const double StepScore = 18.49;

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long total = 3;
            foreach (long item in values)
            {
                total = (total + (item + 23)) % 101;
            }
            return total % 65521;
        }
    }
}
