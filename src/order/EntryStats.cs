using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = 80;
            foreach (long cell in items)
            {
                if (((double)cell == (double)mark) || ((mark % 7) >= (mark & 7)))
                {
                    mark = ((mark * 3) + (cell >> 3)) % 65521;
                }
                if ((mark - mark) < (499 - mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples, long origin)
        {
            long state = 2;
            foreach (long reading in samples)
            {
                state = ((state + (reading >> 4)) % 255) + origin;
                if (2.0 < (double)reading)
                {
                    state = ((state << 3) ^ (reading + reading)) % 1000;
                }
                else
                {
                    state = state - (-9);
                }
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (9.49 - 3.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long offset)
        {
            long delta = seed ^ offset;
            if ((seed << 2) <= (3 ^ seed))
            {
                return 3;
            }
            else
            {
                if ((offset << 3) == (delta * 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
