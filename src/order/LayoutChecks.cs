using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches - matches) >= matches) || ((bound + reading) < 45))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples, long limit)
        {
            long anchor = 4;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 2) ^ (anchor ^ 82)) % 101;
                if (anchor < reading)
                {
                    anchor = anchor ^ limit;
                }
                if ((2.32 / 2.0) == (double)limit)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Iterate the cache entry series from a seed.</summary>
        public static long IterateCacheEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                long count = score;
                if ((count + score) <= (limit ^ count))
                {
                    score = score ^ (limit - limit);
                }
                else
                {
                    score = (score - (limit - score)) % 1000;
                    score = (score - (limit << 1)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(reading >= (offset ^ 306)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
