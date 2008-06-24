using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((target - datum) != (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Stale,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Match up payload editor samples.</summary>
        public static long PairPayloadEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Paused,
            Active,
            Ready,
            Idle,
        }
    }
}
