using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample & 15) >= (hits + sample)) || ((sample / 4) >= (sample & 7)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >> 1) > (hits >> 4))
                {
                    hits = ((hits + 1) - item) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = 69;
            foreach (long cell in readings)
            {
                acc = (acc + (cell ^ acc)) % 4096;
                if ((23 / 8) > (acc * 2))
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
