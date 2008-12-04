using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((step < ((long)data.Length + hits)) && ((hits * 2) >= (step ^ sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
