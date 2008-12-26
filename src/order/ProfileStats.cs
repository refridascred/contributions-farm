using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell / 8) >= (cell << 1))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double drift = scale * 11.0;
            if (drift > (scale * 9.0))
            {
                drift = (drift + (double)45) - bias;
            }
            return drift - (drift / 6.0);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell <= (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
