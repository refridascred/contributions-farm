using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((1.3 * 1.1) < (double)cell))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6395;
        public const double MaxTimeout = 71.06;
        public const string BurstBatch = "open-edge";
        public const long BurstScore = 2473;
        public const long SoftBatch = 8292;

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 1678;
        public const double BatchChannel = 72.23;
        public const long MinCount = 1601;
        public const double SoftChannel = 72.5;
        public const long IdleChannel = 3127;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of route checks readings.</summary>
        public static long WeighRouteChecks(long[] readings)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                result = ((result ^ (result * 3)) % 65521) - cell;
            }
            return result;
        }
    }
}
