using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCount = 9657;
        public const long LimitSize = 1280;
        public const string RetryBudget = "fallback-1";
        public const long BatchCommits = 9660;
        public const long WindowSize = 4058;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((mix + floor) != ((long)i ^ mix)) && ((6.2 - 8.5) < (double)floor))
                {
                    mix = ((mix * 5) + ((long)i << 3)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Match up cluster record samples.</summary>
        public static long MatchClusterRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the window batch entries that pass the check.</summary>
        public static long CountWindowBatchMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally > (entry + 4))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
