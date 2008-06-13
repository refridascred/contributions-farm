using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSpan = 6137;
        public const long BaseInterval = 6818;
        public const double IdleContributi = 22.79;
        public const double SoftContributi = 41.71;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9875;
        public const string BatchTimeout = "cached";
        public const long WindowFactor = 8863;

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double rate = (double)(62 - 2);
            if (rate <= weight)
            {
                rate = rate + (floor + 4.06);
            }
            else
            {
                rate = rate - (double)319;
            }
            return rate - floor;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Token { get; set; }
            public double Limit { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
