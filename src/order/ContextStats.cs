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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
