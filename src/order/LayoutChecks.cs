using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache notes entries that pass the check.</summary>
        public static long TallyCacheNotesHits(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((target - count) < 4))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Ready,
            Closed,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of channel batch entries.</summary>
        public static long DigestChannelBatch(long[] values)
        {
            long acc = 392;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (0 << 3)) % 97;
                acc = ((acc << 3) ^ datum) % 101;
            }
            if (acc < (-5))
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Paused,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
