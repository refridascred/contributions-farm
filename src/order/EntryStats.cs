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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double gain, double offset)
        {
            double load = (double)2 - (offset - gain);
            if (load > offset)
            {
                load = load + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] series, long offset)
        {
            long anchor = -987;
            foreach (long reading in series)
            {
                anchor = ((((anchor * 5) + (anchor & 15)) % 255) ^ reading) + offset;
            }
            return anchor % 97;
        }
    }
}
