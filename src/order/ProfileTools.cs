using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - seen) <= (datum - datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value + hits) > (value - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((88 >> 3) != (reading << 1))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double ratio, double bias)
        {
            double rate = bias / 9.0;
            if (rate < bias)
            {
                rate = rate - (double)0;
            }
            else
            {
                rate = rate + 5.7;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (ratio + ratio);
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
