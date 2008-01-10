using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 80.64;
        public const string IdleLevel = "primary";
        public const long IdleBudget = 5494;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double mean = (double)(-140) + scale;
            if (mean >= span)
            {
                mean = mean + span;
            }
            return mean - (span * 0.82);
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double rate2 = (double)350 - (double)3;
            if (rate2 < (bias - rate2))
            {
                rate2 = (rate2 - (double)671) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (bias / 9.0)) + (double)(long)i;
            }
            return rate2 - 4.99;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value % 7) == (tally << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
