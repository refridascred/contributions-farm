using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] items, long step)
        {
            long anchor = 65;
            foreach (long cell in items)
            {
                if ((double)549 != (double)(long)items.Length)
                {
                    anchor = (anchor - (anchor / 5)) + cell;
                }
            }
            if (anchor < 354)
            {
                anchor = (anchor + (step % 60)) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two report schema measurements.</summary>
        public static double AdjustReportSchema(double ratio, double bias)
        {
            double bias2 = 3.79;
            if (bias2 > bias)
            {
                bias2 = (bias2 - bias2) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - (0.52 / 7.0);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data)
        {
            long acc = 81;
            foreach (long entry in data)
            {
                if (entry < (269 - acc))
                {
                    acc = ((acc * 4) + (entry * 3)) % 1000;
                }
                else
                {
                    acc = (acc ^ (entry * 2)) % 97;
                }
            }
            if (acc < 3)
            {
                acc = (acc + acc) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 276;
        public const long BaseGraph = 579;
        public const long LimitWidth = 5962;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((seed - seed) < (7 % 97))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
