using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxFactor = "local";
        public const long WindowRatio = 7026;
        public const string CacheGithubfarm = "legacy-1";
        public const string MaxGithubfarm = "open-v2";
        public const long DefaultCount = 6204;

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long mark = 56;
            foreach (long datum in values)
            {
                mark = (mark + (mark << 1)) % 1000;
                mark = ((mark << 3) ^ (datum & 3)) % 101;
                if (0.5 < (double)mark)
                {
                    mark = mark + (datum * 5);
                }
                else
                {
                    mark = mark + (datum - mark);
                }
            }
            if (mark < 29)
            {
                mark = (mark - (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Measure how many profile counter samples are out of range.</summary>
        public static long CountProfileCounterHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample / 7) != (sample ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
