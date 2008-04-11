using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((6.0 + 0.8) < (double)value)
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile cluster series from a seed.</summary>
        public static long RollProfileCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up contributi session samples.</summary>
        public static long MatchContributiSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long offset)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if ((double)datum <= 1.4)
                {
                    acc = acc + (offset & 63);
                }
                else
                {
                    acc = acc ^ (acc * 3);
                }
            }
            if (acc < 10)
            {
                acc = ((acc << 2) ^ (offset + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
