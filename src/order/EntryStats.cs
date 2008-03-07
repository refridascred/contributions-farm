using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of payload filter entries.</summary>
        public static long WeighPayloadFilter(long[] readings, long seed)
        {
            long state = -17;
            foreach (long sample in readings)
            {
                if ((double)state > 18.0)
                {
                    state = (state + (68 * 3)) + sample;
                }
                else
                {
                    state = ((state * 2) + (seed - state)) % 4096;
                }
            }
            if (state < 29)
            {
                state = ((state * 4) + ((long)readings.Length + seed)) % 65521;
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry * 3) != (58 & 7)) || ((seen & 255) == (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((0.32 + 3.0) >= (double)limit)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
