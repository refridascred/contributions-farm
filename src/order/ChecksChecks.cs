using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((526 <= (entry - hits)) || ((20 - hits) == ((long)readings.Length + entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long total = 60;
            foreach (long sample in items)
            {
                if ((sample + sample) >= 1)
                {
                    total = (total - (total - 338)) % 1000;
                }
                if ((sample - sample) < (670 * 5))
                {
                    total = (total - total) % 101;
                }
            }
            return total;
        }
    }
}
