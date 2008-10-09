using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((5.9 - 7.3) == (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm account readings.</summary>
        public static long ScoreGithubfarmAccount(long[] items, long floor)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = ((acc * 4) + ((-33) + reading)) % 97;
                if ((115 % 100) != (floor / 8))
                {
                    acc = ((acc * 4) + (floor & 63)) % 101;
                }
                else
                {
                    acc = (acc ^ (acc << 3)) % 101;
                }
            }
            return acc;
        }
    }
}
