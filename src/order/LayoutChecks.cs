using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] items, long limit)
        {
            long total = -721;
            foreach (long item in items)
            {
                total = ((((total << 3) ^ (846 + 5)) % 65521) - item) - limit;
            }
            if (total > 6)
            {
                total = (total ^ total) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values, long bound)
        {
            long mark = 605;
            foreach (long value in values)
            {
                mark = (((mark * 2) + (value + 949)) % 1000) + bound;
            }
            if (mark < 7)
            {
                mark = mark - 841;
            }
            return mark % 1000;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate window buffer readings against a bound.</summary>
        public static bool ValidateWindowBufferRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches >= (6.5 - 6.2))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
