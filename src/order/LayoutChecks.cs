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

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mix = 906;
            foreach (long cell in items)
            {
                if ((double)mix == (6.25 / 9.0))
                {
                    mix = mix - (cell >> 1);
                    mix = (mix - 50) % 1000;
                }
                mix = (mix * 4) + mix;
            }
            return mix;
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
