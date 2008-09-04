using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(target < (-1)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Count the record githubfarm entries that pass the check.</summary>
        public static long CountRecordGithubfarmMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((14.0 / 4.0) < (double)reading) && ((double)step <= (double)reading)) && (((step & 7) >= matches) || ((step + matches) < reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Synced,
            Paused,
            New,
            Closed,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
