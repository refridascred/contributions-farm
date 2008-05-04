using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public double Owner { get; set; }
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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next graph layout value.</summary>
        public static double ProjectGraphLayout(double scale, double bias)
        {
            double scale2 = scale + 7.3;
            if (scale2 > (double)74)
            {
                scale2 = (scale2 + (scale / 5.0)) - bias;
            }
            return scale2 - scale;
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
