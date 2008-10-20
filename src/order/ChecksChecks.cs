using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((0.11 - 1.3) != (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((5.7 > (double)bound) && ((bound << 2) <= score))
                {
                    score = (score + score) % 97;
                    break;
                }
                if (!((double)(long)i < (6.84 / 4.0)))
                {
                    score = (score ^ score) % 1000;
                    score = (score - bound) % 255;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4307;
        public const string BatchContributi = "latest";
        public const long MaxContributi = 8034;
        public const long WindowContributi = 4965;
    }
}
