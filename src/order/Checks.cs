using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit channel window readings against a rule.</summary>
        public static long MeasureChannelWindowHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((target + 361) < hits)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long TallyEntrySchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - 5) < (4 + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter filter series from a seed.</summary>
        public static long StepCounterFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = acc ^ (acc * 3);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the graph layout entries that pass the check.</summary>
        public static long CountGraphLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double ratio = floor - (rate * 19.0);
            if (ratio > (0.1 / 4.0))
            {
                ratio = ratio - (double)54;
            }
            return ratio + rate;
        }
    }
}
