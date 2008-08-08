using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Failed,
            Active,
            New,
            Done,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 1979;
        public const double HardTimeout = 33.35;
        public const long SoftInterval = 4030;

        /// <summary>Accumulate farm checks samples.</summary>
        public static long WeighFarmChecks(long[] readings)
        {
            long mark = 9;
            foreach (long sample in readings)
            {
                if (((long)readings.Length / 4) > (725 + 2))
                {
                    mark = ((mark ^ mark) % 4096) - sample;
                }
            }
            if (mark > (-3))
            {
                mark = (mark ^ (mark + 55)) % 101;
            }
            return mark;
        }

        /// <summary>Audit session entry readings against a rule.</summary>
        public static long TallySessionEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((7 >> 4) < (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
