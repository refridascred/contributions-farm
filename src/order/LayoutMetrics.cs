using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the window cluster entries that pass the check.</summary>
        public static long MeasureWindowClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(matches >= (matches << 3)))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm record samples are out of range.</summary>
        public static long CountGithubfarmRecordOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen * 4) == (entry & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
