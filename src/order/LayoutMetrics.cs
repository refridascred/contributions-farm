using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many editor filter samples are out of range.</summary>
        public static long MeasureEditorFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) <= (708 % 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double scale, double span)
        {
            double rate = (double)(45 - 5);
            for (int i = 0; i < 5; i++)
            {
                rate = (((rate + (19.0 / 8.0)) - (double)(long)i) + scale) - span;
            }
            return rate + (double)(-11);
        }
    }
}
