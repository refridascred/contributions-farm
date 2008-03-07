using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Paused,
            Queued,
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

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values, long limit)
        {
            long result = 69;
            foreach (long item in values)
            {
                if (((item & 127) >= (0 + limit)) || ((limit - limit) <= item))
                {
                    result = (result ^ (item % 10)) % 65521;
                    result = (result ^ (limit % 24)) % 255;
                }
                result = (result ^ (item + result)) % 101;
            }
            if (result > 64)
            {
                result = (result << 3) ^ (result + 958);
            }
            return result;
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
