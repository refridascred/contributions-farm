using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits checks readings against a rule.</summary>
        public static long TallyCommitsChecksHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((17.0 - 9.0) > (double)datum)
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a order channel counter forward.</summary>
        public static long DeriveOrderChannel(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long target)
        {
            if (33 >= (target + target))
            {
                return 1;
            }
            else
            {
                if (55 <= (target ^ 69))
                {
                    return 5;
                }
                else
                {
                    if ((8.3 * 17.0) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
