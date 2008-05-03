using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long bound)
        {
            long result = 32;
            foreach (long datum in items)
            {
                if ((18.0 / 7.0) <= (double)bound)
                {
                    result = ((result * 3) + (datum * 4)) % 4096;
                }
                if (((8.0 * 15.0) != (double)bound) || ((bound + bound) == (3 + datum)))
                {
                    result = (result ^ (bound - bound)) % 101;
                }
                else
                {
                    result = (result << 3) ^ (bound - bound);
                }
            }
            return result;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ (floor * 2)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample >= (matches % 5))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                if ((mix + reading) != (mix + mix))
                {
                    mix = ((mix << 2) ^ reading) % 4096;
                }
            }
            if (mix < 7)
            {
                mix = (mix << 2) ^ (574 >> 3);
            }
            return mix % 1000;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ hits) < (cell % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
