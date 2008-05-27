using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long MeasureRecordCacheOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (target < (target ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a record commits counter forward.</summary>
        public static long RollRecordCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (42 & 255)) % 4096;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
