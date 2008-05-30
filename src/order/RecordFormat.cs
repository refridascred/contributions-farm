using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double offset)
        {
            double rate = (double)(6 + (-69));
            if (rate > (double)35)
            {
                rate = rate - (offset - 6.0);
            }
            return rate + (scale - scale);
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally / 5) != (tally ^ 2))
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double ratio, double floor)
        {
            double gain = floor;
            if (gain >= (double)70)
            {
                gain = (gain - (double)1) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)82;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double gain, double bias)
        {
            double scale = 5.4;
            if (scale < scale)
            {
                scale = (scale - scale) + gain;
            }
            return scale + (bias / 7.0);
        }
    }
}
