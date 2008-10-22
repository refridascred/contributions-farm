using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen / 3) <= 922) || ((seen * 2) > ((-795) + seen)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a schema batches sample.</summary>
        public static long FindSchemaBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
