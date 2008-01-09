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

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public string Level { get; set; } = "";
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
