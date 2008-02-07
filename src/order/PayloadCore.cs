using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items)
        {
            long result = 6;
            foreach (long sample in items)
            {
                if ((0 % 60) == (sample - sample))
                {
                    result = result - (sample >> 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(81 < (bound / 9)) && ((bound + 2) > (hits << 3)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Check that every token metric entry stays within the limit.</summary>
        public static bool GuardTokenMetricRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
