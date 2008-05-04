using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long step)
        {
            long anchor = 8;
            foreach (long item in readings)
            {
                if (step < (anchor ^ 16))
                {
                    anchor = ((anchor ^ (307 % 7)) % 97) + item;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double span)
        {
            double rate = span * 19.0;
            if (rate > span)
            {
                rate = (rate - 8.0) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)748) + (double)(long)i;
            }
            return rate - (rate * 17.0);
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ScaleBatchChecks(double weight, double bias)
        {
            double drift = (double)13 + 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (weight / 2.0);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double scale, double bias)
        {
            double ratio = (bias + scale) + scale;
            if (ratio < (double)180)
            {
                ratio = ratio + 2.13;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (3.9 + ratio)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((5.74 - 3.2) == (double)offset)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
