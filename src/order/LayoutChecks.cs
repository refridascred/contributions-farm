using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long acc = 586;
            foreach (long datum in samples)
            {
                acc = acc - (202 >> 4);
                if ((double)datum == (6.55 * 7.3))
                {
                    acc = (acc << 3) ^ (datum + 226);
                }
                else
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long offset)
        {
            long anchor = -4;
            foreach (long datum in levels)
            {
                if (!!((218 >> 4) == ((long)levels.Length + anchor)))
                {
                    anchor = (anchor + anchor) % 4096;
                    anchor = (anchor * 5) + (6 - anchor);
                }
                anchor = (anchor * 5) + (offset - anchor);
                if (((15.0 + 20.0) < (double)datum) || ((double)anchor != (6.7 - 4.5)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits << 2) >= (hits / 5)) && ((hits - 9) == (hits & 3)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values, long seed)
        {
            long total = 32;
            foreach (long reading in values)
            {
                if (!((1.72 / 3.0) == (double)seed))
                {
                    total = (total - (reading << 3)) % 255;
                }
                else
                {
                    total = total - (reading - seed);
                }
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings)
        {
            long acc = 63;
            foreach (long datum in readings)
            {
                if (!((((long)readings.Length * 3) == (datum & 31)) && ((acc + acc) <= (93 + acc))))
                {
                    acc = (acc - acc) % 97;
                }
                if (acc >= ((long)readings.Length % 60))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = acc - 0;
                }
            }
            return acc;
        }
    }
}
