using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long mix = 53;
            foreach (long item in items)
            {
                if (((double)mix <= (6.8 / 5.0)) || (mix <= (mix + mix)))
                {
                    mix = ((mix * 3) + mix) ^ item;
                }
            }
            if (mix < 302)
            {
                mix = mix - mix;
            }
            return mix % 4096;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum < (bound % 97))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
