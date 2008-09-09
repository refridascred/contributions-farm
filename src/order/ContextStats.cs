using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a payload notes reading.</summary>
        public static double AdjustPayloadNotes(double rate, double span)
        {
            double scale = (rate / 8.0) + rate;
            if (scale > rate)
            {
                scale = (scale - scale) + span;
            }
            return scale - rate;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
