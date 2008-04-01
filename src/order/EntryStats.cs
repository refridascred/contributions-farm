using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long acc = 6;
            foreach (long datum in series)
            {
                acc = acc - (datum + acc);
                if ((acc * 2) == (datum >> 2))
                {
                    acc = ((acc * 2) + datum) % 4096;
                }
                else
                {
                    acc = (acc << 2) ^ (datum ^ step);
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value % 8) == (678 % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((hits << 3) > ((long)series.Length + cell)) || ((hits / 3) < hits)) || ((cell > ((long)series.Length + cell)) && ((hits << 3) >= cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Failed,
            Draft,
            Ready,
            New,
        }
    }
}
