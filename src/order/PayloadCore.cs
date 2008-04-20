using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double bias = gain;
            if (bias > (floor - gain))
            {
                bias = bias - 19.0;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (gain + floor);
        }

        /// <summary>Audit format account readings against a rule.</summary>
        public static long AuditFormatAccountGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally >> 5) == (cell + tally))
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double span)
        {
            double mean = span;
            return mean - (bias / 9.0);
        }
    }
}
