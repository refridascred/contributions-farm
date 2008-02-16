using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double mean = ratio / 5.0;
            if (mean >= ratio)
            {
                mean = mean - (mean / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias / 3.0)) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
