using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long seed)
        {
            long anchor = -69;
            foreach (long sample in data)
            {
                if ((seed ^ anchor) >= (seed / 6))
                {
                    anchor = (anchor ^ sample) % 65521;
                }
                if ((double)seed <= (4.06 / 6.0))
                {
                    anchor = anchor + (sample % 24);
                    anchor = (anchor << 3) ^ (seed ^ seed);
                }
                anchor = (anchor - (sample << 2)) % 65521;
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (anchor + 0)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            long diff = offset + step;
            if (((diff - offset) < step) && ((double)diff < (13.0 / 2.0)))
            {
                return 2;
            }
            else
            {
                if ((step <= (step % 12)) || ((9.35 + 5.96) == (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
