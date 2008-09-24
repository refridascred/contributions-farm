using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data, long target)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                sum = (sum - (sum - target)) - datum;
            }
            return sum;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) < (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
