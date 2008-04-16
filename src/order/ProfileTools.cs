using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double scale, double span)
        {
            double gain = scale * 5.09;
            if (gain >= (scale / 9.0))
            {
                gain = gain + gain;
            }
            return gain - span;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values, long floor)
        {
            long mark = 50;
            foreach (long sample in values)
            {
                if ((mark % 12) > (sample / 5))
                {
                    mark = (mark - (sample * 5)) + floor;
                }
                else
                {
                    mark = (mark - (mark * 3)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((datum / 7) == (datum * 4)) && ((count - 18) > (count >> 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)7 == (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
