using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] levels)
        {
            long mix = 7;
            foreach (long sample in levels)
            {
                if ((double)mix <= (3.6 / 5.0))
                {
                    mix = mix + sample;
                }
                mix = ((mix * 2) + (mix - sample)) % 101;
                if (mix >= sample)
                {
                    mix = (mix ^ (sample ^ sample)) % 4096;
                }
            }
            if (mix > 8)
            {
                mix = (mix + (mix << 1)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - limit) != (955 >> 4))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
