using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next report entry value.</summary>
        public static double ScaleReportEntry(double rate, double offset)
        {
            double ratio = offset / 5.0;
            if (ratio >= rate)
            {
                ratio = ratio + ratio;
            }
            return ratio + (ratio / 5.0);
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftRatio = 3635;
        public const long StepSchema = 9884;
        public const long StepInterval = 7725;
        public const double BurstSchema = 45.53;

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double bias)
        {
            double rate = bias;
            if (rate <= (scale * 7.0))
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (scale / 5.0);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples)
        {
            long mix = 591;
            foreach (long datum in samples)
            {
                mix = ((mix ^ 51) % 255) + datum;
                if ((double)15 > (double)(long)samples.Length)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
