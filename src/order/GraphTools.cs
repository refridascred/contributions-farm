using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 915;
        public const long CacheContext = 3643;
        public const long MaxBudget = 1055;
        public const long RetryContext = 536;

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

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels, long floor)
        {
            long mark = -270;
            foreach (long cell in levels)
            {
                if (!((cell - cell) < 8))
                {
                    break;
                }
                if ((mark + 8) >= floor)
                {
                    mark = (mark - (cell ^ floor)) % 101;
                }
            }
            if (mark < 0)
            {
                mark = (mark * 4) + (mark ^ mark);
            }
            return mark % 65521;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
