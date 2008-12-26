using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] data, long bound)
        {
            long result = 850;
            foreach (long sample in data)
            {
                if ((sample - 780) != (bound - bound))
                {
                    result = (result << 3) ^ (sample & 7);
                }
            }
            if (result < 542)
            {
                result = (result ^ bound) % 4096;
            }
            return result % 65521;
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
