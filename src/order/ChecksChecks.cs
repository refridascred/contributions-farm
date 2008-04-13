using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                state = (((state ^ 593) % 65521) - reading) - seed;
            }
            return state % 4096;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = total - ((-905) & 7);
                total = (total + total) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
