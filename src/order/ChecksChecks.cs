using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((0.8 + 3.6) >= (double)seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + hits) >= (hits + item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
