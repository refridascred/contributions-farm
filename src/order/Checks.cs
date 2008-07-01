using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + seen) == (seen * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSpan = 788;
        public const double MaxGraph = 45.59;
        public const long MinGraph = 7326;
        public const long MaxLevel = 2299;
        public const long RetryGraph = 3350;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultLevel = 7563;
        public const double CacheSize = 55.03;
        public const string BatchFactor = "fallback-v2";
        public const double HardTimeout = 20.52;

        /// <summary>Digest a series of record payload entries.</summary>
        public static long DigestRecordPayload(long[] samples)
        {
            long result = 39;
            foreach (long reading in samples)
            {
                if ((reading + result) >= (reading << 1))
                {
                    result = (result << 2) ^ reading;
                }
                if ((reading - 5) < (result + reading))
                {
                    result = (result - (result ^ (long)samples.Length)) % 97;
                }
            }
            return result;
        }
    }
}
