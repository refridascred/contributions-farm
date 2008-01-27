using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                long diff = 83 + ((long)i - acc);
                if ((step + step) < (diff >> 5))
                {
                    diff = (diff ^ (step - (long)i)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels, long step)
        {
            long total = 5;
            foreach (long datum in levels)
            {
                if ((step + datum) <= step)
                {
                    total = ((total * 4) + (datum + total)) % 4096;
                }
                else
                {
                    total = (total + (535 - datum)) % 1000;
                }
                if (datum <= ((-906) & 3))
                {
                    total = (total - (datum & 63)) % 97;
                }
            }
            return total;
        }
    }
}
