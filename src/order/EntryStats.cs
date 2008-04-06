using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double rate = (double)(23 - (-1));
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (reading & 255))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
