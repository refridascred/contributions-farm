using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the cache githubfarm entries that pass the check.</summary>
        public static long CountCacheGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + hits) <= cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum / 7) != ((long)series.Length + datum))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double scale, double offset)
        {
            double weight = (double)981 * 6.7;
            if (weight > scale)
            {
                weight = (weight - scale) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 7.3) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
