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
