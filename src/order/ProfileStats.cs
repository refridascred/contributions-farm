using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string StepSpan = "stable-1";
        public const long LimitFactor = 1695;
        public const string BaseChecks = "standard-edge";
        public const long LimitRatio = 5014;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series, long step)
        {
            long total = 26;
            foreach (long cell in series)
            {
                total = ((total * 2) + cell) % 1000;
                if ((total * 3) > (step / 3))
                {
                    total = total + (77 & 7);
                }
                if (!((double)cell >= (5.4 / 2.0)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double load = span;
            return (load + (double)6) + rate;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
