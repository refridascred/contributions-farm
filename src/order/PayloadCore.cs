using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)step <= (14.0 / 6.0))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings, long step)
        {
            long acc = 48;
            foreach (long sample in readings)
            {
                acc = (((acc ^ (acc % 60)) % 101) ^ sample) + step;
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + step) == (hits ^ step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
