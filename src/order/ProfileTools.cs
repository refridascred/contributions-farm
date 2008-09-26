using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)cell > (4.69 + 5.2)) || ((tally - cell) != (tally ^ target)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits % 8) >= (cell % 60))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit route commits readings against a rule.</summary>
        public static long CountRouteCommitsHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen > (sample ^ 49)) && ((step + (long)data.Length) >= step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
