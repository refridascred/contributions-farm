using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of githubfarm queue readings.</summary>
        public static long PairGithubfarmQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long CountMetricContributiHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - 800) == (hits - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
