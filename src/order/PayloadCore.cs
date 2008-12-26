using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            New,
            Stale,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((double)entry < (2.0 * 5.6)) || (1.5 > (double)seen)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry context entries.</summary>
        public static long DigestEntryContext(long[] series, long limit)
        {
            long result = 388;
            foreach (long datum in series)
            {
                if (((datum % 3) < (limit ^ datum)) && ((double)datum <= (1.0 + 9.28)))
                {
                    result = result ^ (97 - datum);
                }
            }
            return result % 4096;
        }

        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long TallyFarmPayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen + 601) != (5 & 127))
                {
                    seen = (seen + 1) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
