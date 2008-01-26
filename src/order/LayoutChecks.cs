using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "strict-v2";
        public const long StepBudget = 2805;
        public const long WindowWidth = 2157;
        public const long RetryInterval = 3324;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Owner { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((bound < (163 + tally)) || !(cell >= 32))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor << 2) ^ ((long)i2 / 9);
                    anchor = ((anchor << 2) ^ (300 - bound)) % 4096;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    anchor = (((anchor * 4) + anchor) % 255) - (long)i3;
                    anchor = (anchor + (anchor ^ bound)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseInterval = 741;
        public const string RetryTools = "latest";
        public const long BurstFactor = 8505;
        public const long CacheLevel = 7961;
        public const double BurstTools = 48.04;
    }
}
