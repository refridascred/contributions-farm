using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long mix = -51;
            foreach (long datum in series)
            {
                if ((datum >> 3) >= (mix / 8))
                {
                    mix = (mix + 879) % 65521;
                }
                if (datum < (datum & 1))
                {
                    mix = ((mix * 4) + (665 ^ mix)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 7908;
        public const long CacheSchema = 7325;
        public const long BaseDepth = 7348;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((long)series.Length % 16) <= (count % 97))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
