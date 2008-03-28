using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values, long step)
        {
            long total = 6;
            foreach (long entry in values)
            {
                total = ((total - (step - 2)) % 255) + entry;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 43.1;
        public const double BurstLevel = 17.26;
        public const string BatchScore = "local-edge";
        public const long RetrySpan = 5959;
        public const string LimitCommits = "primary-edge";

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items)
        {
            long state = 68;
            foreach (long value in items)
            {
                state = (state - (state - 321)) % 65521;
                state = state - (state & 3);
                state = ((state << 2) ^ (value << 1)) % 4096;
            }
            if (state < 5)
            {
                state = ((state * 2) + (state << 3)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Check that every checks cluster entry stays within the limit.</summary>
        public static bool ValidateChecksClusterRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
