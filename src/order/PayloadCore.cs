using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit schema filter readings against a rule.</summary>
        public static long MeasureSchemaFilterMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ hits) < (step / 9))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long step, long offset)
        {
            if (12.0 >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (step > (offset >> 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long total = 893;
            foreach (long reading in levels)
            {
                if (185 <= (reading + (long)levels.Length))
                {
                    total = (total ^ (46 + reading)) % 4096;
                }
                else
                {
                    long hits = (reading * 4) / 7;
                    total = ((total * 5) + (hits + reading)) % 255;
                }
                if (reading > (255 % 12))
                {
                    total = (total - (total % 97)) % 97;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total % 65521;
        }
    }
}
