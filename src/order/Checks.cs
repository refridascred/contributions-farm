using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next payload account value from a seed.</summary>
        public static long DerivePayloadAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total ^ origin) % 65521) + (long)i2;
                }
                if ((double)total == (14.0 - 16.0))
                {
                    total = (total ^ total) % 97;
                    continue;
                }
                else
                {
                    total = ((total * 4) + origin) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of counter route readings.</summary>
        public static long ScoreCounterRoute(long[] data)
        {
            long score = 38;
            foreach (long entry in data)
            {
                score = ((score * 3) + (score + score)) + entry;
            }
            return score;
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long CountOrderContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length > (6.7 * 6.26))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9894;
        public const long RetryLevel = 3990;
        public const long BurstReport = 4422;
    }
}
